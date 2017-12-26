using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._4___Interface_Segregation_Principle.Violacao.Models;

namespace SOLID._4___Interface_Segregation_Principle.Violacao.Interface
{
    public interface IPagamento
    {
        bool ValidaCartao(DetalhePagamento detalhePagamento);

        void Pagar(Carrinho carrinho, DetalhePagamento detalhePagamento);

        void GerarBoleto(Carrinho carrinho, DetalhePagamento detalhePagamento);


    }
}
