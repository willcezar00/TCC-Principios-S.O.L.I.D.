using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SOLID._4___Interface_Segregation_Principle.Solucao.Interface;
using SOLID._4___Interface_Segregation_Principle.Solucao.Models;

namespace SOLID._4___Interface_Segregation_Principle.Solucao.Services
{
    public class BoletoService: IPagamentoBoleto,IPagamento
    {
        public void GerarBoleto(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            throw new NotImplementedException();
        }

        public void Pagar(Carrinho carrinho, DetalhePagamento detalhePagamento)
        {
            try
            {
                GerarBoleto(carrinho, detalhePagamento);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
