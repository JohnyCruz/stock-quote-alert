using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_stock_quote_alert
{
    public class Validacao
    {
        public static bool ValidaParametrosEntrada(string[] args)
        {
            if (args.Length != 3) return false;
            bool ativoValido = !string.IsNullOrWhiteSpace(args[0]);
            bool referenciaVendaValido = Decimal.TryParse(args[1], out decimal valorVenda);
            bool referenciaCompraValido = Decimal.TryParse(args[2], out decimal valorCompra);
            bool vendaMaiorQueCompra = valorVenda > valorCompra;
            return ativoValido && referenciaVendaValido && referenciaCompraValido && vendaMaiorQueCompra;
        }

        public static bool ValidaAtivoEstaDisponivelAPI(string ativo)
        {
            try
            {
                bool ativoValido = false;
                if (string.IsNullOrEmpty(ativo)) return ativoValido;
                foreach (string ativoDisponivel in LeitorDeArquivos.ativosDisponveis())
                {
                    if (ativoDisponivel.Split(';')[0].Contains(ativo))
                    {
                        ativoValido = true;
                        break;
                    }
                }
                return ativoValido;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public static bool ValidaArquivoDeConfiguracao()
        {
            List<string> AllKeys = System.Configuration.ConfigurationManager.AppSettings.AllKeys.ToList<string>();

            bool keyEmailToIsValid = AllKeys.Contains("EmailTo")
                   && !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["EmailTo"].ToString())
                   && !string.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.AppSettings["EmailTo"].ToString());

            bool keyEmailFromIsValid = AllKeys.Contains("EmailFrom")
                   && !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["EmailFrom"].ToString())
                   && !string.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.AppSettings["EmailFrom"].ToString());

            bool keyCredentialEmailIsValid = AllKeys.Contains("CredentialEmail")
                   && !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["CredentialEmail"].ToString())
                   && !string.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.AppSettings["CredentialEmail"].ToString());

            bool keyCredentialPassowordIsValid = AllKeys.Contains("CredentialPassword")
                   && !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["CredentialPassword"].ToString())
                   && !string.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.AppSettings["CredentialPassword"].ToString());

            bool keySMTPHostIsValid = AllKeys.Contains("SMTPHost")
                   && !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["SMTPHost"].ToString())
                   && !string.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.AppSettings["SMTPHost"].ToString());

            bool keySMTPPortIsValid = AllKeys.Contains("SMTPPort")
                   && !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["SMTPPort"].ToString())
                   && !string.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.AppSettings["SMTPPort"].ToString());
            
            bool keyAPIKeyIsValid = AllKeys.Contains("APIKey")
                   && !string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["APIKey"].ToString())
                   && !string.IsNullOrWhiteSpace(System.Configuration.ConfigurationManager.AppSettings["APIKey"].ToString());


            return keyEmailToIsValid
                && keyEmailFromIsValid
                && keyCredentialEmailIsValid
                && keyCredentialPassowordIsValid
                && keySMTPHostIsValid
                && keyAPIKeyIsValid;

        }

    }
}
