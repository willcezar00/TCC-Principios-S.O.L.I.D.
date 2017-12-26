using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID.Violação;
using SOLID.Violação.Models;
using Quadrado = SOLID.Violação.Quadrado;


namespace UnitTestProject1._3___Liskov_Substitution_Principle.Violação
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
            Assert.AreEqual(24, retangulo.AreaRetangulo());
        }

        [TestMethod]
        public void Retangulo7X9()
        {
            var retangulo = new Retangulo
            {
                Altura = 7,
                Largura = 9
            };
            Assert.AreEqual(63, retangulo.AreaRetangulo());
        }

        [TestMethod]
        public void Retangulo5X10()
        {
            var quadrado = new Quadrado()
            {
                Altura = 5,
                Largura = 10
            };
            Assert.AreEqual(50, quadrado.AreaRetangulo());
        }
    }
}