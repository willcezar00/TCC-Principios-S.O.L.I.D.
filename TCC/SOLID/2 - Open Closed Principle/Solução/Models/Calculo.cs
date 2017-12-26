using SOLID.Solução.Interface;

namespace SOLID.Solução.Models
{
    public class Calcular
    {
        public void CalcularArea(ICalculo formasGeometricas)
        {
            formasGeometricas.Area();
        }
    }
}
