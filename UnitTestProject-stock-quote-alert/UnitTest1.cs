﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary_stock_quote_alert;

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
    }
}
