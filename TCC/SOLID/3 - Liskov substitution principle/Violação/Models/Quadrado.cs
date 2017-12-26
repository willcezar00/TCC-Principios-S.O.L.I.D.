using SOLID.Violação.Models;

namespace SOLID.Violação
{
    //Na Geometria um quadrado "È um" Retangulo 
    public  class Quadrado : Retangulo
    {
        //Sobescreve o método set para que Altura e Largura tenham o mesmo valor
        public override double Largura
        {
            set
            {
                base.Largura = base.Altura = value; 
            }
        }
        public override double Altura
        {
            set
            {
                base.Altura = base.Largura = value;
            } 
        }
    }
}
