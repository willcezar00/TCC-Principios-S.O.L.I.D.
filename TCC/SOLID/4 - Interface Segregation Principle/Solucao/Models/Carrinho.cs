using System.Collections.Generic;

namespace SOLID._4___Interface_Segregation_Principle.Solucao.Models
{
    public class Carrinho
    {
        public decimal  Total { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        public Cliente Cliente { get; set; }
    }
}
