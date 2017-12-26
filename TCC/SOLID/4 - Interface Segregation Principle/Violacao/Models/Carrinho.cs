using System.Collections.Generic;

namespace SOLID._4___Interface_Segregation_Principle.Violacao.Models
{
    public class Carrinho
    {
        public decimal  Total { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        public Cliente Cliente { get; set; }
    }
}
