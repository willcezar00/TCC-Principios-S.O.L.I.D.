using System;
using SOLID._1___Single_Responsibility_Principle.Violação.Services;
using SOLID._5___Dependency_Inversion_Principle.Solução.Interface;


namespace SOLID._5___Dependency_Inversion_Principle.Solução.Models
{
    public class CartaoService : IPagamento
    {
        public void Pagar(Carrinho carrinho)
        {
            try
            {
                //método de pagamento por cartão
            }
            catch (AvsMismatchException ex)
            {
                throw new Exception("O Cartao foi rejeitado.", ex);
            }
        }
    }
}
