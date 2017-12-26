using System;
using SOLID._1___Single_Responsibility_Principle.Solucao.Models;
using SOLID._1___Single_Responsibility_Principle.Violação.Services;

namespace SOLID._1___Single_Responsibility_Principle.Solucao.Services
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
