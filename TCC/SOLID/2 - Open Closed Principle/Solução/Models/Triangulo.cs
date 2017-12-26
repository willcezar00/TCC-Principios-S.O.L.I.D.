using System;
using SOLID.Solução.Interface;

namespace SOLID.Solução.Models
{
    public class Triangulo : ICalculo
    {
        public double Lado { get; set; }

        public double Altura { get; set; }

        public double Area()
        {
            try
            {
                return Lado * Altura;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
