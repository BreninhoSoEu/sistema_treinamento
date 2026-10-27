namespace sistema_treinamento.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int Quantidade_min { get; set; }
        public string TipoMov { get; set; }
        public DateTime DataMov { get; set; }
        public int IdCliente { get; set; }

    }
}
