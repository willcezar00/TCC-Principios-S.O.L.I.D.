namespace SOLID._1___Single_Responsibility_Principle.Solucao.Models
{
    public enum MetodoPagamento
    {
        Cartao,
        Boleto
    }

    public class DetalhePagamento
    {
        public MetodoPagamento MetodoPagamento { get; set; }

        public string NumeroDoCartao { get; set; }

        public string MesValidade { get; set; }

        public string AnoValidade { get; set; }

        public string NomeDoCartao { get; set; }
    }
}