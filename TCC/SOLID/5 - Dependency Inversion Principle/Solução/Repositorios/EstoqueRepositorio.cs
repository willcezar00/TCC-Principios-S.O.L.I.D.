using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID._5___Dependency_Inversion_Principle.Solução.Interface;

namespace SOLID._5___Dependency_Inversion_Principle.Solução.Models
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {
        public int GetEstoqueProduto(string nome)
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
