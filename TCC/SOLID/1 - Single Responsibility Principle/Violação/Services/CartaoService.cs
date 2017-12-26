using System;

namespace SOLID._1___Single_Responsibility_Principle.Violação.Services
{
    public class CartaoService : IDisposable
    {
        public string Numero { get; set; }

        public string Credenciais { get; set; }

        public string MesVencimento { get; set; }

        public string AnoVencimento { get; set; }

        public string NomeDoCartao { get; set; }

        public decimal Valor { get; set; }

        public void Charge()
        {
            throw new AvsMismatchException();
        }

        public void Dispose()
        {
        }
    }

    public class AvsMismatchException : Exception
    {
    }
}