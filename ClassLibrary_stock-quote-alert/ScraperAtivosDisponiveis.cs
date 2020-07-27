using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_stock_quote_alert
{
    public class ScraperAtivosDisponiveis
    {
        public static bool Atualizar()
        {
            string arquivoAtivos = Path.Combine("Resources", "ativos_disponiveis.txt");
            string arquivoAtivosBKP = Path.Combine("Resources", "ativos_disponiveis_bkp.txt");
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArguments("headless");
                IWebDriver driver = new ChromeDriver("./", chromeOptions);
                ICapabilities capabilities = ((RemoteWebDriver)driver).Capabilities;
                //Console.WriteLine((capabilities.GetCapability("chrome") as Dictionary<string, object>)["chromedriverVersion"]);

                //IWebDriver driver = new ChromeDriver(Path.Combine("Resources"));
                driver.Navigate().GoToUrl("https://console.hgbrasil.com/documentation/finance/symbols");

                var ativos = driver.FindElements(By.CssSelector("body > div > div.content-page > div > div.container-fluid > div:nth-child(2) > div > div > div > ul > li"));
                if (ativos.Count == 0) return false;
                foreach (var nomeAtivo in ativos)
                {
                    stringBuilder.AppendLine($"{nomeAtivo.Text.Split('-').LastOrDefault().Trim()};{nomeAtivo.Text.Replace(" - " + nomeAtivo.Text.Split('-').LastOrDefault().Trim(), "")}");
                }
                driver.Dispose();
            }
            catch (Exception)
            {
                return false;
            }

            try
            {
                if (File.Exists(arquivoAtivos)) File.Copy(arquivoAtivos, arquivoAtivosBKP,true);
                using (StreamWriter streamWriter = new StreamWriter(Path.Combine("Resources", "ativos_disponiveis.txt"),false,Encoding.UTF8))
                {
                    streamWriter.Write(stringBuilder.ToString());
                }
                
            }
            catch (Exception)
            {
                if (File.Exists(arquivoAtivosBKP)) File.Copy(arquivoAtivosBKP,arquivoAtivos, true);
                return false;
            }
            return true;
        }
    }
}
