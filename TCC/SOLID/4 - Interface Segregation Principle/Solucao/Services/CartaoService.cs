using System;
using SOLID._1___Single_Responsibility_Principle.Violação.Services;
using SOLID._4___Interface_Segregation_Principle.Solucao.Interface;
using SOLID._4___Interface_Segregation_Principle.Solucao.Models;


namespace SOLID._4___Interface_Segregation_Principle.Solucao.Services
{
    public class CartaoService : IPagamentoCartao,IPagamento
    {
        public void Pagar(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            try
            {
                if (ValidaCartao(detalhePagamento))
                {
                    //Finaliza compra com operador contratada
                }
            }
            catch (AvsMismatchException ex)
            {
                throw new Exception("O Cartao foi rejeitado.", ex);
            };
        }

        public bool ValidaCartao(DetalhePagamento detalhePagamento)
        {
            return Convert.ToInt32(detalhePagamento.AnoValidade) > Convert.ToInt32(DateTime.Now.Year);
        }

      
    }
}
