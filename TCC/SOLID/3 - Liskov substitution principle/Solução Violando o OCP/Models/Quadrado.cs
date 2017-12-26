using SOLID._3___Liskov_substitution_principle.Solução.Solução_Violando_o_OCP;

namespace SOLID.Solução.Solução_Violando_o_OCP.Models
{
    public class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public double Area()
        {
            return Lado * Lado;
        }
    }
}
