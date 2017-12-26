using SOLID.Violação.Models;

namespace SOLID.Violação
{
    public static class Calculo
    {
        public static double AreaRetangulo(this Retangulo retangulo)
        {
            return retangulo.Largura * retangulo.Altura;
        }
  

        public static double AreaQuadrado(this Quadrado quadrado)
        {
            return quadrado.Largura * quadrado.Largura;
        }
    }
}
