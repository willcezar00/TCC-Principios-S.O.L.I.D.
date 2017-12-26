using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___Liskov_substitution_principle.Solução
{
    public class Calculo
    {
        public double Area(FormaGeometrica formaGeometrica)
        {
            return formaGeometrica.Area();
        }
    }
}
