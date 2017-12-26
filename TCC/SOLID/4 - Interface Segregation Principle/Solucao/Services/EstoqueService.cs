using System;
using System.Data.SqlClient;
using SOLID._4___Interface_Segregation_Principle.Solucao.Models;


namespace SOLID._4___Interface_Segregation_Principle.Solucao.Services
{
    public  class EstoqueService 
    {
        public bool Verifica(Carrinho carrinho)
        {

            foreach (var produto in carrinho.Produtos)
            {
                try
                {
                   if(GetEstoqueProduto(produto.Nome) < produto.Quantidade) 
                        return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Produto Insuficiente " + produto.Nome, ex);
                }
            }

            return true;
        }
        internal int GetEstoqueProduto(string nome)
        {
            var quantidadeEmEstoque = 0;
            using (var connection = new SqlConnection())
            {
                connection.Open();

                using (SqlCommand command =
                    new SqlCommand("SELECT Quantidade from Produto where Nome =" + nome, connection))

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        quantidadeEmEstoque = reader.GetInt32(0);
                    }
                }
            }
            return quantidadeEmEstoque;
        }
    }
}
