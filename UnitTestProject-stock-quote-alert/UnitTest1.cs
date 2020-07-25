using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary_stock_quote_alert;
using Newtonsoft.Json.Linq;

namespace UnitTestProject_stock_quote_alert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestaEntradaDeParametros()
        {
            string[] args = new string[3] { "PETR4", "22.67", "22.59" };
            Assert.IsFalse(Validacao.ValidaParametrosEntrada(new string[1] {"PETR4"}),
                           "Usuário passou apenas 1 parâmetro de entrada");
            Assert.IsFalse(Validacao.ValidaParametrosEntrada(new string[2] { "PETR4", "22.67"}),
                           "Usuário passou apenas 2 parâmetros de entrada");
            Assert.IsTrue(Validacao.ValidaParametrosEntrada(new string[3] { "PETR4", "22.67", "22.59" }),
                           "Usuário passou 3 parâmetros de entrada");
            Assert.IsFalse(Validacao.ValidaParametrosEntrada(new string[3] { "", "22.67", "22.59" }),
                           "Nome do ativo em branco");
            Assert.IsFalse(Validacao.ValidaParametrosEntrada(new string[3] { "PETR4", "STRING", "22.59" }),
                           "Valor referencia venda é string");
            Assert.IsFalse(Validacao.ValidaParametrosEntrada(new string[3] { "PETR4", "22.67", "STRING" }),
                           "Valor referencia compra é string");
            Assert.IsFalse(Validacao.ValidaParametrosEntrada(new string[3] { "PETR4", "22.67", "22.77" }),
                           "Valor referencia compra é maior do que a referencia de venda");
            Assert.IsTrue(Validacao.ValidaParametrosEntrada(new string[3] { "PETR4", "22.67", "22.59" }),
                           "Usuário passou 3 parâmetros de entrada e todos os valores estão como esperado");

        }
        [TestMethod]
        public void TestaSeAtivoEFornecidoPelaAPI()
        {
            string[] args = new string[3] { "PETR4", "22.67", "22.59" };
            Assert.IsFalse(Validacao.ValidaAtivoEstaDisponivelAPI(null),
                           "Usuário forneceu um ativo nulo");
            Assert.IsFalse(Validacao.ValidaAtivoEstaDisponivelAPI(string.Empty),
               "Usuário forneceu um ativo em branco");
            Assert.IsFalse(Validacao.ValidaAtivoEstaDisponivelAPI("PETR5"),
               "Usuário forneceu um ativo inválido");
            Assert.IsTrue(Validacao.ValidaAtivoEstaDisponivelAPI("PETR4"),
                           "Usuário fonrceu um ativo válido");
            
        }
        [TestMethod]
        public void TestaArquivoDeConfiguracoesEstaCorreto()
        {
            Assert.IsTrue(Validacao.ValidaArquivoDeConfiguracao(),"O Arquivo de validação está configurado corretamente");

        }

        [TestMethod]
        public void TestaBuscaDeAtivos()
        {
            JObject result = APIAtivos.BuscarAtivo("");
            Assert.IsTrue((Boolean)result["results"]["error"]);
            result = APIAtivos.BuscarAtivo("XOUD");
            Assert.IsTrue((Boolean)result["results"]["XOUD"]["error"]);
            result = APIAtivos.BuscarAtivo(null);
            Assert.IsTrue((Boolean)result["results"]["error"]);

            result = APIAtivos.BuscarAtivo("PETR4");
            Assert.IsNull(result["results"]["error"]);
            result = APIAtivos.BuscarAtivo("PETR4");
            Assert.IsNotNull(result["results"]["PETR4"]);
            Assert.IsNotNull(result["results"]["PETR4"]["price"]);
            Assert.IsTrue(Decimal.TryParse(result["results"]["PETR4"]["price"].ToString(), out decimal price));

        }
        
        [TestMethod]
        public void TestaEnvioDeEmail()
        {
            Assert.IsTrue(Email.Enviar("SUBJECT", "BODY"), "Testa envio de email");
            
        }


    }
}
