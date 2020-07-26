using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_stock_quote_alert
{
    public class APIAtivos
    {
        public static JObject BuscarAtivo(string ativo)
        {
            try
            {
                if (string.IsNullOrEmpty(ativo) || string.IsNullOrWhiteSpace(ativo)) ativo = string.Empty;
                string apiKey = System.Configuration.ConfigurationManager.AppSettings["APIKey"];
                UriBuilder uriBuilder = new UriBuilder("https://api.hgbrasil.com/finance/stock_price");
                uriBuilder.Query = $"key={apiKey}&symbol={ativo}";

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriBuilder.Uri);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                string json = string.Empty;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
                return (JObject)JsonConvert.DeserializeObject(json);
            }
            catch(Exception ex)
            {
                return new JObject();
            }


            
        }
    }
}
