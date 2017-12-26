
using SOLID._1___Single_Responsibility_Principle.Solucao.Services;

namespace SOLID._1___Single_Responsibility_Principle.Solucao.Models
{
    public class Pedido 
    {
        //Dependencia de Classes
        private readonly EstoqueService _estoqueService = new EstoqueService();
        private readonly CartaoService _cartaoService = new CartaoService();
        private readonly NotificacaoService _notificaoService = new NotificacaoService();

        public void Checkout(Carrinho carrinho)
        {
            if (_estoqueService.Verifica(carrinho))
            {
                _cartaoService.Pagar(carrinho);

                _notificaoService.EnviaEmail(carrinho);
            }
        }
    }
}
