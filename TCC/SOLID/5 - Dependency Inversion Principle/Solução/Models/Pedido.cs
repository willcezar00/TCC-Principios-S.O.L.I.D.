using SOLID._5___Dependency_Inversion_Principle.Solução.Interface;

namespace SOLID._5___Dependency_Inversion_Principle.Solução.Models
{
    public class Pedido 
    {
        private readonly INotificacao _notificacao;
        private readonly IVerificaEstoque _verificaEstoque;
        private readonly IPagamento _pagamento;

        public Pedido(INotificacao notificacao,
                      IVerificaEstoque verificaEstoque,
                      IPagamento pagamento)
        {
            //usando Injetor de dependencia
            _notificacao = notificacao;
            _verificaEstoque = verificaEstoque;
            _pagamento = pagamento; 
        }

        public void Checkout(Carrinho carrinho)
        {
            if (_verificaEstoque.Verifica(carrinho))
            {
                _pagamento.Pagar(carrinho);
                _notificacao.EnviaEmail(carrinho);
            }
        }
    }
}
