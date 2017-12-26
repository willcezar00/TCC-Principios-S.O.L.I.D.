using System;
using System.Collections.Generic;
using SOLID._2___Open_Closed_Principle.Violação.Models;

namespace SOLID.Violação.Models
{
    public class Calculo
    {
        public void CalcularArea(FormaGeometrica formaGeometrica)
        {
            if (formaGeometrica.GetType() == typeof(Quadrado))
            {
                AreaQuadrado(formaGeometrica as Quadrado);
            }

            if (formaGeometrica.GetType() == typeof(Circulo))
            {
                AreaCirculo(formaGeometrica as Circulo);
            }
        }

        public double AreaQuadrado(Quadrado quadrado)
        {
            return quadrado.Lado * quadrado.Lado;
        }

        public double AreaCirculo(Circulo circulo)
        {
            return Math.PI * Math.Pow(circulo.Raio,2);
        }
    }
}
