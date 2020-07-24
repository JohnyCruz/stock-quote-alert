using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_stock_quote_alert
{
    public class LeitorDeArquivos
    {
        public static List<string> ativosDisponveis()
        {
            try
            {
                string arquivoAtivos = "ativos_disponiveis.csv";
                string resourcePath = Path.Combine("Resources", arquivoAtivos);
                if (!File.Exists(resourcePath)) return new List<string>();
                using (StreamReader reader = new StreamReader(resourcePath))
                {
                    return reader.ReadToEnd().Split('\n').ToList<string>();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
