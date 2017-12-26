namespace SOLID._4___Interface_Segregation_Principle.Solucao.Models
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