using SOLID.Solução.Interface;

namespace SOLID.Solução.Models
{
    public class Quadrado : ICalculo
    {
        public double Lado { get; set; }

        public double Area()
        {
            return Lado * Lado;
        }
    }
}
