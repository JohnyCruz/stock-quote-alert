using ClassLibrary_stock_quote_alert;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace stock_quote_alert
{
    class Program
    {
        private static System.Timers.Timer timer;
        private static EntradaUsuario entradaUsuario;
        private static CultureInfo usCulture;
        static void Main(string[] args)
        {
            checarArquivoDeConfiguracao();
            if (!Validacao.ValidaParametrosEntrada(args))
            {
                Console.WriteLine("Os parâmetros de entrada não estão no formato correto. Seguir o exemplo:\n'Ativo'  'Referência para venda' 'Referência para compra'\nPETR4 22.67 22.59");
                Environment.Exit(0);
            }
            entradaUsuario = new EntradaUsuario();
            usCulture = new CultureInfo(System.Configuration.ConfigurationManager.AppSettings["Culture"]);
            entradaUsuario.ativo = args[0];
            entradaUsuario.referenciaVenda = Convert.ToDecimal(args[1], usCulture);
            entradaUsuario.referenciaCompra = Convert.ToDecimal(args[2], usCulture);
            if (!ScraperAtivosDisponiveis.Atualizar()) Console.WriteLine("Não foi possível consultar novos ativos, vamos utilizar os ativos disponíveis na ultima atualização.");

            if (!Validacao.ValidaAtivoEstaDisponivelAPI(entradaUsuario.ativo))
            {
                Console.WriteLine("Nós não fornecemos suporte para este ativo. Gostaria de saber para quais ativos temos suporte?(S\\N)");
                string answer = Console.ReadLine().ToUpper();
                if (answer.Equals("S"))
                {
                    foreach (var ativo in LeitorDeArquivos.ativosDisponveis())
                    {
                        Console.WriteLine(ativo);
                    }
                    Console.WriteLine("Tente novamente com um dos ativos suportados.");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    //Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (answer.Equals("N"))
                {
                    Console.WriteLine("Tudo bem, a aplicação será encerrada.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Comando desconhecido a aplicação será encerrada.");
                    Environment.Exit(1);
                }
            }

            timer = new System.Timers.Timer();
            timer.Interval = 1000 * 60 * 15;// A api é atualizada a cada 15 minutos, então a requisição será feita a cada 15 minutos
            timer.Elapsed += OnTimedEvent;
            //timer.AutoReset = true;
            // Start the timer
            timer.Enabled = true;

            Console.WriteLine("Para sair do programa aperte qualquer tecla... ");
            Console.ReadLine();
        }
        private static void checarArquivoDeConfiguracao()
        {
            if (!Validacao.ValidaArquivoDeConfiguracao())
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("Dentro da pasta do aplicativo abra o arquivo \"stock-quote-alert.exe.config\" e adicione as tags abaixo dentro da tag \"configuration\"")
                              .AppendLine("<appSettings>")
                              .AppendLine("  <add key=\"EmailTo\" value=\"JohnyInoa@gmail.com\"/>")
                              .AppendLine("  <add key=\"EmailFrom\" value=\"JohnyInoa@gmail.com\"/>")
                              .AppendLine("  <add key=\"CredentialEmail\" value=\"JohnyInoa@gmail.com\"/>")
                              .AppendLine("  <add key=\"CredentialPassword\" value=\"teste#1aoni\"/>")
                              .AppendLine("  <add key=\"SMTPHost\" value=\"smtp.gmail.com\"/>")
                              .AppendLine("  <add key=\"SMTPPort\" value=\"587\"/>")
                              .AppendLine("  <add key=\"APIKey\" value=\"9368a2aa\"/>")
                              .AppendLine("  <add key=\"Culture\" value=\"en-US\"/>")
                              .AppendLine("</appSettings>");
                Console.WriteLine(stringBuilder.ToString());
                Console.WriteLine("Tente novamente após configurar o app");
                Environment.Exit(1);
            }
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {

            Console.WriteLine($"O evento foi disparado às {e.SignalTime}");
            checarArquivoDeConfiguracao();

            JObject respostaAPI = APIAtivos.BuscarAtivo(entradaUsuario.ativo);
            if (!(respostaAPI["results"]["error"] is null))
            {
                Console.WriteLine($"Falha ao conectar com a API às {e.SignalTime}. Detalhes: {respostaAPI["results"]["message"].ToString()}");
            }
            else
            {
                Decimal precoAtivoAtual = Convert.ToDecimal(respostaAPI["results"][entradaUsuario.ativo]["price"], usCulture);
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
                    
                    if(Email.Enviar("[stock-quote-alert] Alerta para compra", corpoDoEmail))
                    {
                        Console.WriteLine("E-mail enviado");
                    }
                    else
                    {
                        Console.WriteLine("Falha ao enviar o email");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"O preço do ativo as {e.SignalTime} estava em {precoAtivoAtual}. O valor de referência para compra é {entradaUsuario.referenciaCompra} e para venda é {entradaUsuario.referenciaVenda}.");
                    Console.WriteLine("Aguardando a api atualizar novamente...");
                }
            }

            
            if(DateTime.Now.TimeOfDay < Convert.ToDateTime("10:00").TimeOfDay || DateTime.Now.TimeOfDay > Convert.ToDateTime("14:30").TimeOfDay)
            {
                //Os valores dos ativos não são atualizados antes das 10:00 e também não são atualizados depois das 17:30, então o app espera
                DateTime startTime = DateTime.Now;
                DateTime endtime = Convert.ToDateTime("10:00");
                DateTime endOftheDay = Convert.ToDateTime("23:59");
                TimeSpan duration = Convert.ToDateTime("10:00").AddDays(1).Subtract(DateTime.Now);
                timer.Stop();
                Console.WriteLine($"Após essa consulta vou dormir por {duration} horas, até amanhã as 10h");
                Thread.Sleep(duration);
                timer.Start();
            }

        }

    }
}
