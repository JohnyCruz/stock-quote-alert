using ClassLibrary_stock_quote_alert;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsForms_stock_quote_alert
{
    public class AbortableBackgroundWorker : BackgroundWorker
    {
        //source: https://stackoverflow.com/questions/800767/how-to-kill-background-worker-completely
        private Thread workerThread;
        private EntradaUsuario entradaUsuario;

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            CultureInfo usCulture = new CultureInfo(System.Configuration.ConfigurationManager.AppSettings["Culture"]);
            workerThread = Thread.CurrentThread;
            try
            {
                bool bgWorkingRunning = false;
                while (!bgWorkingRunning)
                {
                    if (this.CancellationPending) break;
                    bgWorkingRunning = true;
                    entradaUsuario = FormMain.entradaUsuario;
                    JObject respostaAPI = APIAtivos.BuscarAtivo(entradaUsuario.ativo);
                    if (!(respostaAPI["results"]["error"] is null))
                    {
                        Console.WriteLine($"Falha ao conectar com a API às {DateTime.Now}. Detalhes: {respostaAPI["results"]["message"].ToString()}");
                    }
                    else
                    {
                        Decimal precoAtivoAtual = Convert.ToDecimal(respostaAPI["results"][entradaUsuario.ativo]["price"], usCulture);
                        entradaUsuario.precoAtual = precoAtivoAtual;
                        if (precoAtivoAtual > entradaUsuario.referenciaVenda)
                        {
                            string corpoDoEmail = LeitorDeArquivos.modeloEmailVenda()
                                .Replace("#Ativo", entradaUsuario.ativo)
                                .Replace("#precoAtivo", precoAtivoAtual.ToString())
                                .Replace("#referenciaDeVenda", entradaUsuario.referenciaVenda.ToString());


                            if (Email.Enviar("[stock-quote-alert] Alerta para venda", corpoDoEmail))
                            {
                                Console.WriteLine("E-mail enviado");
                            }
                            else
                            {
                                Console.WriteLine("Falha ao enviar o email");
                            }
                        }
                        else if (precoAtivoAtual < entradaUsuario.referenciaCompra)
                        {
                            string corpoDoEmail = LeitorDeArquivos.modeloEmailCompra()
                                .Replace("#Ativo", entradaUsuario.ativo)
                                .Replace("#precoAtivo", precoAtivoAtual.ToString())
                                .Replace("#referenciaDeCompra", entradaUsuario.referenciaCompra.ToString());
                            Email.Enviar("[stock-quote-alert] Alerta para compra", corpoDoEmail);


                        }
                    }


                    if (DateTime.Now.TimeOfDay < Convert.ToDateTime("10:00").TimeOfDay || DateTime.Now.TimeOfDay > Convert.ToDateTime("17:30").TimeOfDay)
                    {
                        //Os valores dos ativos não são atualizados antes das 10:00 e também não são atualizados depois das 17:30, então o app espera
                        DateTime startTime = DateTime.Now;
                        DateTime endtime = Convert.ToDateTime("10:00");
                        DateTime endOftheDay = Convert.ToDateTime("23:59");
                        TimeSpan duration = Convert.ToDateTime("10:00").AddDays(1).Subtract(DateTime.Now);
                        if (((int)DateTime.Now.DayOfWeek) == 6)
                        {
                            duration = Convert.ToDateTime("10:00").AddDays(2).Subtract(DateTime.Now);
                        }
                        else if (((int)DateTime.Now.DayOfWeek) == 5)
                        {
                            duration = Convert.ToDateTime("10:00").AddDays(3).Subtract(DateTime.Now);
                        }
                        else
                        {
                            duration = TimeSpan.FromMilliseconds(1000 * 60 * 15); // A api é atualizada a cada 15 minutos, então a requisição será feita a cada 15 minutos
                        }
                        FormMain.entradaUsuario = entradaUsuario;
                        this.ReportProgress(1);
                        //Thread.Sleep(duration); //TODO: Remover esse comentário para o app funcionar durante o tempo que a API é atualizada
                        Thread.Sleep(1000 * 60 * 1);
                        
                    }
                    
                    bgWorkingRunning = false;
                }

                
                base.OnDoWork(e);
            }
            catch (ThreadAbortException)
            {
                e.Cancel = true; //We must set Cancel property to true!
                Thread.ResetAbort(); //Prevents ThreadAbortException propagation
            }
        }


        public void Abort()
        {
            if (workerThread != null)
            {
                workerThread.Abort();
                workerThread = null;
            }
        }
    }
}
