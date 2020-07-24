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
            else return true;
        }
    }
}
