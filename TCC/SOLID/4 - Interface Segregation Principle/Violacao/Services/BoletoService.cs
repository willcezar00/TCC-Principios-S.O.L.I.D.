using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._4___Interface_Segregation_Principle.Violacao.Interface;
using SOLID._4___Interface_Segregation_Principle.Violacao.Models;

namespace SOLID._4___Interface_Segregation_Principle.Violacao.Services
{
    public class BoletoService : IPagamento
    {

        public bool ValidaCartao(DetalhePagamento detalhePagamento)
        {
            //BoletoService não implementa este método
            throw new NotImplementedException();
        }

        public void Pagar(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            //BoletoService não implementa este método
            throw new NotImplementedException();
        }

        public void GerarBoleto(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {

            try
            {
                //Gerar Boleto para o o cliente
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

     
    }
}
