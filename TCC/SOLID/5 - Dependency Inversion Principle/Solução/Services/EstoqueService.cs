using System;
using System.Data.SqlClient;
using SOLID._5___Dependency_Inversion_Principle.Solução.Interface;

namespace SOLID._5___Dependency_Inversion_Principle.Solução.Models
{
   
    public  class EstoqueService : IVerificaEstoque
    {
        private readonly IEstoqueRepositorio _estoqueRepositorio;

        public EstoqueService(IEstoqueRepositorio estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }

        public bool Verifica(Carrinho carrinho)
        {

            foreach (var produto in carrinho.Produtos)
            {
                try
                {
                   if(_estoqueRepositorio.GetEstoqueProduto(produto.Nome) < produto.Quantidade) 
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
