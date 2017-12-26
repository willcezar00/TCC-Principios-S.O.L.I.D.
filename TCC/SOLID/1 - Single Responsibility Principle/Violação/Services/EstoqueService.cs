using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Build.Utilities;

namespace SOLID._1___Single_Responsibility_Principle.Violação.Services
{
    public class EstoqueService
    {
        public bool Verifica(string nome, int quantidadeSolicitada)
        {
            var quantidadeEmEstoque = GetEstoqueProduto(nome);

            return quantidadeEmEstoque > quantidadeSolicitada;
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



        public class InsufficientInventoryException : Exception
        {
            //implentar a excessão
        }
    }
}
