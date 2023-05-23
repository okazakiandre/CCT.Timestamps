namespace CCT.Timestamps.App
{
    public class Pedido
    {
        public int Numero { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }
    }
}
