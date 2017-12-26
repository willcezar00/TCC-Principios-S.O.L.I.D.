using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Solução.Solução_Violando_o_OCP.Models;
using SOLID._3___Liskov_substitution_principle.Solução.Solução_Violando_o_OCP;

namespace SOLID._3___Liskov_substitution_principle.Solução_Violando_o_OCP.Models
{
    public class Calculo
    {
        public void Area(FormaGeometrica formaGeometrica)
        {
            //Violação o OCP
            if (formaGeometrica.GetType() == typeof(Quadrado))
            {
                ((Quadrado) formaGeometrica).Area();
            }
            if (formaGeometrica.GetType() == typeof(Retangulo))
            {
                ((Retangulo)formaGeometrica).Area();
            }
        }
    }
}
