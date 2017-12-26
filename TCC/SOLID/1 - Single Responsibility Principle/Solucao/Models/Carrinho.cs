using System.Collections.Generic;
using SOLID._5___Dependency_Inversion_Principle.Violação.Models;

namespace SOLID._1___Single_Responsibility_Principle.Solucao.Models
{
    public class Carrinho
    {
        public decimal  Total { get; set; }

        public ICollection<Produto> Produtos { get; set; }

        public Cliente Cliente { get; set; }
    }
}
