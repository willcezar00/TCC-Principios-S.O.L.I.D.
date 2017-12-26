using System.Collections.Generic;

namespace SOLID._1___Single_Responsibility_Principle.Violação.Models
{
    public class Carrinho
    {
        public decimal  Total { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        public Cliente Cliente { get; set; }
    }
}
