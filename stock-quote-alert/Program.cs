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
        public static bool timerAtivo = false;
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("Aguarde um momento enquanto o sistema realiza as validações necessárias.");
            Console.WriteLine("*************************************************");
            checarArquivoDeConfiguracao();
            if (!Validacao.ValidaParametrosEntrada(args))
            {
                Console.WriteLine("Os parâmetros de entrada não estão no formato correto. Seguir o exemplo:");
                Console.WriteLine("'Ativo'  'Referência para venda' 'Referência para compra'");
                Console.WriteLine("PETR4 22.67 22.59");
                Console.WriteLine("Nota1: O preço de referência para venda deve ser maior do que o preço de referência para compra.");
                Console.WriteLine("Nota2: Altere as configurações padrões no arquivo \"stock - quote - alert.exe.config\" para colocar suas próprias informações.");
                
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
            timer.Interval = 100;
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
            timer.Start();
            Console.WriteLine("************************************************* ");
            Console.WriteLine("Para sair do programa pressione qualquer tecla... ");
            Console.WriteLine("*************************************************");
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
            if (timerAtivo) return;
            timerAtivo = true;
            Console.WriteLine("*************************************************");
            Console.WriteLine($"O evento foi disparado às {DateTime.Now}");
            checarArquivoDeConfiguracao();
            Console.WriteLine($"Estou monitorando o ativo:{entradaUsuario.ativo}");
            Console.WriteLine($"Estou monitorando o ativo enviarei um email caso o preço esteja maior que {entradaUsuario.referenciaVenda.ToString("#.00", CultureInfo.InvariantCulture)} ou menor que {entradaUsuario.referenciaCompra.ToString("#.00", CultureInfo.InvariantCulture)}.");
            Console.WriteLine("*************************************************");
            JObject respostaAPI = APIAtivos.BuscarAtivo(entradaUsuario.ativo);
            if (!(respostaAPI["results"]["error"] is null))
            {
                Console.WriteLine($"Falha ao conectar com a API às {DateTime.Now}. Detalhes: {respostaAPI["results"]["message"].ToString()}");
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

                    if (Email.Enviar("[stock-quote-alert] Alerta para compra", corpoDoEmail))
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
                    Console.WriteLine($"O preço do ativo as {DateTime.Now} estava em {precoAtivoAtual.ToString("#.00", CultureInfo.InvariantCulture)}. O valor de referência para compra é {entradaUsuario.referenciaCompra.ToString("#.00", CultureInfo.InvariantCulture)} e para venda é {entradaUsuario.referenciaVenda.ToString("#.00", CultureInfo.InvariantCulture)}.");
                }
                Console.WriteLine("Aguardando a api atualizar novamente...");
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
                timer.Stop();
                Console.WriteLine($"Tempo de espera até a próxima consulta: {duration.ToString("c")}");
                Thread.Sleep(duration);
                timer.Start();
            }

            timerAtivo = false;

        }

    }
}
