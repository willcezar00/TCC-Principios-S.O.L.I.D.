using System;
using SOLID._1___Single_Responsibility_Principle.Violação.Services;
using SOLID._5___Dependency_Inversion_Principle.Violação.Models;

namespace SOLID._5___Dependency_Inversion_Principle.Violação.Services
{
    public class CartaoService 
    {
        public void Pagar(Carrinho carrinho)
        {
            try
            {
                //implementar o pagamento
            }
            catch (AvsMismatchException ex)
            {
                throw new Exception("O Cartao foi rejeitado.", ex);
            }
        }
    }
}
