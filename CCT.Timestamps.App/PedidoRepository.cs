namespace CCT.Timestamps.App
{
    public class PedidoRepository : IPedidoDados
    {
        public Pedido Obter(int numero)
        {
            return new Pedido
            {
                Numero = numero,
                Descricao = "Pedido Novo",
                DataCriacao = DateTime.Today
            };
        }

        public void Incluir(Pedido pedido)
        {

        }

        public void Alterar(Pedido pedido)
        {

        }
    }
}
