namespace CCT.Timestamps.App
{
    public class IncluirPedidoUseCase
    {
        private IPedidoDados PedDados { get; }
        
        public IncluirPedidoUseCase(IPedidoDados ped) 
        {
            PedDados = ped;
        }

        public Pedido Executar(string descricao)
        {
            var pedido = new Pedido
            {
                Descricao = descricao,
                DataCriacao = DateTime.Today
            };
            PedDados.Incluir(pedido);
            return pedido;
        }
    }
}
