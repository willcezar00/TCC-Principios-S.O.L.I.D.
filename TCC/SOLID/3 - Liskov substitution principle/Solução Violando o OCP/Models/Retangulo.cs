using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3___Liskov_substitution_principle.Solução.Solução_Violando_o_OCP
{
    public class Retangulo : FormaGeometrica
    {
        public double Altura { get; set; }

        public double  Largura { get; set; }


        public double Area()
        {
            return Altura * Largura;
        }
    }
}
