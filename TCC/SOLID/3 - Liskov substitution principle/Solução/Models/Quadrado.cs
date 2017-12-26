using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___Liskov_substitution_principle.Solução
{
    public class Quadrado: FormaGeometrica
    {
        public double Lado { get; set; }

        public override double Area()
        {
            return Lado * Lado;
        }
    }
}
