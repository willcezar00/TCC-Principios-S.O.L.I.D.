using System;
using SOLID.Solução.Interface;

namespace SOLID.Solução.Models
{
    public class Circulo : ICalculo
    {
        public double Raio { get; set; }

        public double Area()
        { 
            return Math.PI * Math.Pow(Raio,2);
        }
    }
}
