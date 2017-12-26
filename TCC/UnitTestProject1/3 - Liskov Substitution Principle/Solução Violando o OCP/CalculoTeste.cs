using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.Solução.Solução_Violando_o_OCP.Models;
using SOLID._3___Liskov_substitution_principle.Solução.Solução_Violando_o_OCP;

namespace UnitTestProject1._3___Liskov_Substitution_Principle.Solução_Violando_o_OCP
{
    [TestClass]
    public class CalculoTeste
    {
        [TestMethod]
        public void Retangulo4X6()
        {
            var retangulo = new Retangulo
            {
                Altura = 4,
                Largura = 6
            };
            Assert.AreEqual(24, retangulo.Area());
        }

        [TestMethod]
        public void Retangulo7X9()
        {
            var retangulo = new Retangulo
            {
                Altura = 7,
                Largura = 9
            };
            Assert.AreEqual(63, retangulo.Area());
        }

        [TestMethod]
        public void Quadrado5()
        {
            var quadrado = new Quadrado()
            {
                Lado = 5
            };
            Assert.AreEqual(25, quadrado.Area());
        }

        [TestMethod]
        public void Retangulo5X10()
        {
            var retangulo = new Retangulo()
            {
                Altura = 5,
                Largura = 10

            };
            Assert.AreEqual(50, retangulo.Area());
        }
    }
}
