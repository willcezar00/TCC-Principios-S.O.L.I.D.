using System;
using System.Data.SqlClient;
using SOLID._4___Interface_Segregation_Principle.Violacao.Models;
using SOLID._4___Interface_Segregation_Principle.Violacao.Repositorios;

namespace SOLID._4___Interface_Segregation_Principle.Violacao.Services
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
                    if (estoqueRepositorio.GetEstoqueProduto(produto.Nome) < produto.Quantidade)
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
