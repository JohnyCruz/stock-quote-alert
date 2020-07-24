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
    }
}
