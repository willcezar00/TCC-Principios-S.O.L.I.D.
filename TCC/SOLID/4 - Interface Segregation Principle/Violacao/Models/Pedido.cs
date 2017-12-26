
using SOLID._4___Interface_Segregation_Principle.Violacao.Services;

namespace SOLID._4___Interface_Segregation_Principle.Violacao.Models
{
    public class Pedido 
    {
        public void Checkout(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            EstoqueService estoqueService = new EstoqueService();
            if (estoqueService.Verifica(carrinho))
            {
                CartaoService cartaoService = new CartaoService();
                cartaoService.Pagar(carrinho, detalhePagamento);

                NotificacaoService notificaoService = new NotificacaoService();
                notificaoService.EnviaEmail(carrinho);
            }
        }
    }
}
