namespace ApiBuscaVoos.Models
{
    public class Voo
    {
        public int VooId { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Chegada { get; set; }
        public string Operadora { get; set; }
        public float Preco { get; set; }

    }
}
