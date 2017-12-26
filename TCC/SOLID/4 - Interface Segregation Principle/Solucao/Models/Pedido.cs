using SOLID._4___Interface_Segregation_Principle.Solucao.Interface;
using SOLID._4___Interface_Segregation_Principle.Solucao.Services;


namespace SOLID._4___Interface_Segregation_Principle.Solucao.Models
{

    public class Pedido
    {
        private readonly IPagamento _pagamento;

        public Pedido(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public void Checkout(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            EstoqueService estoqueService = new EstoqueService();
            if (estoqueService.Verifica(carrinho))
            {
                //DIP
                //CartaoService cartaoService = new CartaoService();
                //cartaoService.Pagar(carrinho, detalhePagamento);

                _pagamento.Pagar(carrinho, detalhePagamento);

                NotificacaoService notificaoService = new NotificacaoService();
                notificaoService.EnviaEmail(carrinho);
            }
        }
    }
}
