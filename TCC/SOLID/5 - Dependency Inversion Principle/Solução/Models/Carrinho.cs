using System.Collections.Generic;

namespace SOLID._5___Dependency_Inversion_Principle.Solução.Models
{
    public class Carrinho
    {
        public decimal  Total { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        public Cliente Cliente { get; set; }
    }
}
