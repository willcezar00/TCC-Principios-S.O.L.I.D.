using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._4___Interface_Segregation_Principle.Solucao.Models;

namespace SOLID._4___Interface_Segregation_Principle.Solucao.Interface
{
    public interface IPagamentoBoleto
    {
        void GerarBoleto(Carrinho carrinho,DetalhePagamento detalhePagamento);
    }
}
