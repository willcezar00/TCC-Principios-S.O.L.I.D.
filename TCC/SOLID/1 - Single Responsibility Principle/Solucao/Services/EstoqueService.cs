using System;
using System.Data.SqlClient;

using SOLID._1___Single_Responsibility_Principle.Solucao.Models;
using SOLID._1___Single_Responsibility_Principle.Solucao.Repositorios;

namespace SOLID._1___Single_Responsibility_Principle.Solucao.Services
{
    public  class EstoqueService 
    {
        public bool Verifica(Carrinho carrinho)
        {
            EstoqueRepositorio estoqueRepositorio = new EstoqueRepositorio();
            foreach (var produto in carrinho.Produtos)
            {
                try
                {
                   if(estoqueRepositorio.GetEstoqueProduto(produto.Nome) < produto.Quantidade) 
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Produto Insuficiente " + produto.Nome, ex);
                }
            }

            return true;
        }
      
    }
}
