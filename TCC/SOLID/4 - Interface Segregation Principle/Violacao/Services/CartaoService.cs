using System;
using SOLID._1___Single_Responsibility_Principle.Violação.Services;
using SOLID._4___Interface_Segregation_Principle.Violacao.Interface;
using SOLID._4___Interface_Segregation_Principle.Violacao.Models;

namespace SOLID._4___Interface_Segregation_Principle.Violacao.Services
{
    public class CartaoService : IPagamento
    {
        public bool ValidaCartao(DetalhePagamento detalhePagamento)
        {
            return Convert.ToInt32(detalhePagamento.AnoValidade) > Convert.ToInt32(DateTime.Now.Year);
        }

        public void Pagar(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            try
            {
                //Efetuar pagamento com operadora do cartão
            }
            catch (AvsMismatchException ex)
            {
                throw new Exception("O Cartao foi rejeitado.", ex);
            }
        }

        public void GerarBoleto(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            //CartaoService não implementa este método
            throw new NotImplementedException();
        }
    }
}
