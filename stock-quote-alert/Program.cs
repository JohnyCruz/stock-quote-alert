using ClassLibrary_stock_quote_alert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock_quote_alert
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Validacao.ValidaArquivoDeConfiguracao())
            {
                Console.WriteLine("Arquivo Valido");
            }

            Console.ReadKey();
        }
    }
}
