

using System;
using System.Data.SqlClient;
using SOLID._5___Dependency_Inversion_Principle.Violação.Models;
using SOLID._5___Dependency_Inversion_Principle.Violação.Repositorios;


namespace SOLID._5___Dependency_Inversion_Principle.Violação.Services
{
    public  class EstoqueService
    {

        EstoqueRepositorio estoqueRepositorio = new EstoqueRepositorio();

        public bool Verifica(Models.Carrinho carrinho)
        {            foreach (var produto in carrinho.Produtos)
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
