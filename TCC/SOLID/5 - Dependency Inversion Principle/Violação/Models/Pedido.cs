using SOLID._5___Dependency_Inversion_Principle.Violação.Services;

namespace SOLID._5___Dependency_Inversion_Principle.Violação.Models
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
