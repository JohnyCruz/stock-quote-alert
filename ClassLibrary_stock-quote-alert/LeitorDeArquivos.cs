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
                string arquivoAtivos = "ativos_disponiveis.txt";
                string resourcePath = Path.Combine("Resources", arquivoAtivos);
                if (!File.Exists(resourcePath)) return new List<string>();
                using (StreamReader reader = new StreamReader(resourcePath))
                {
                    return reader.ReadToEnd().Split('\n').ToList<string>();
                }
            }
            catch (Exception ex)
            {
                List<string> lista = new List<string>();
                lista.Add("Falha ao ler os ativos disponíveis");
                return lista;
            }
        }

        public static string LeArquivoHTML(string nomeArquivo)
        {
            try
            {
                var fileStocks = nomeArquivo;
                string resourcePath = Path.Combine("Resources", fileStocks);

                using (StreamReader reader = new StreamReader(resourcePath))
                {

                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

                return string.Empty;
            }
        }
        public static string modeloEmailCompra()
        {
            try
            {
                return LeArquivoHTML("ModeloEmailCompra.html");
            }
            catch (Exception)
            {
                return "Está na hora de comprar o ativo #Ativo, pois está com o preco #precoAtivo e o preco de referencia é #referenciaDeCompra";
            }
        }

        public static string modeloEmailVenda()
        {
            try
            {
                return LeArquivoHTML("ModeloEmailVenda.html");
            }
            catch (Exception)
            {
                return "Está na hora de vender o ativo #Ativo, pois está com o preco #precoAtivo e o preco de referencia é #referenciaDeVenda";
            }
        }
    }
}
