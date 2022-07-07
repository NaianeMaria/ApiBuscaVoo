namespace ApiBuscaVoos.Models
{
    public class Viagem
    {
        public int ViagemId { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Chegada { get; set; }

    }
}
