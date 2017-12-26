
using SOLID._5___Dependency_Inversion_Principle.Solução.Models;

namespace SOLID._5___Dependency_Inversion_Principle.Solução.Interface
{
    public interface IVerificaEstoque
    {
        bool Verifica(Carrinho carrinho);
    }
}
