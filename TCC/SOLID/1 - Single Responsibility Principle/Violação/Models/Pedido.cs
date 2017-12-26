using System;
using System.Globalization;
using System.Net.Mail;
using SOLID._1___Single_Responsibility_Principle.Violação.Services;

namespace SOLID._1___Single_Responsibility_Principle.Violação.Models
{
    public class Pedido
    {
        public void Checkout(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            if (VerificaEstoque(carrinho))
            {
                PagarCartao(carrinho,detalhePagamento);
                NotificaCliente(carrinho);
            }
        }

        public void NotificaCliente(Carrinho carrinho)
        {
            string emailCliente = carrinho.Cliente.Email;
            if (!string.IsNullOrEmpty(emailCliente))
            {
                using (var mensagem = new MailMessage("notificação@suporte", emailCliente))
                using (var cliente = new SmtpClient("localhost"))
                {
                    mensagem.Subject = "Recebemos seu pedido feito as : " + 
                        DateTime.Now.ToString(CultureInfo.InvariantCulture);

                    mensagem.Body = "Detalhes do Pedido " + carrinho.ToString();

                    try
                    {
                        cliente.Send(mensagem);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Ocorreu um erro.");
                    }
                }
            }
        }

        public void PagarCartao(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            using (var cartaoService = new CartaoService())
            {
                try
                {
                    cartaoService.Credenciais = "Credenciais do Cliente";
                    cartaoService.Numero = detalhePagamento.NumeroDoCartao;
                    cartaoService.MesVencimento = detalhePagamento.MesValidade;
                    cartaoService.AnoVencimento = detalhePagamento.AnoValidade;
                    cartaoService.NomeDoCartao = detalhePagamento.NomeDoCartao;
                    cartaoService.Valor = carrinho.Total;

                    cartaoService.Charge();
                }
                catch (AvsMismatchException ex)
                {
                    throw new OrderException("O Cartao foi rejeitado.", ex);
                }
                catch (Exception ex)
                {
                    throw new OrderException("Houve um problema com o cartão.", ex);
                }
            }
        }

        public bool VerificaEstoque(Carrinho carrinho)
        {
            foreach (var produto in carrinho.Produtos)
            {
                try
                {
                    //Violação do Dependency Inversion Principle
                    var estoqueService = new EstoqueService();

                    if (!estoqueService.Verifica(produto.Nome, produto.Quantidade))
                    {
                        return false;
                    };

                }
                catch (EstoqueService.InsufficientInventoryException ex)
                {
                    throw new OrderException("Produto Insuficiente " + produto.Nome, ex);
                }
             
            }
            return true;
        }

        public class OrderException : Exception
        {
            public OrderException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }
    }
}
