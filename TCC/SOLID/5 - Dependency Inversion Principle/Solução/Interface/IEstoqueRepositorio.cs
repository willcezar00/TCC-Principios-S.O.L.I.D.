using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5___Dependency_Inversion_Principle.Solução.Interface
{
    public interface IEstoqueRepositorio
    {
         int GetEstoqueProduto(string nome);
    }
}
