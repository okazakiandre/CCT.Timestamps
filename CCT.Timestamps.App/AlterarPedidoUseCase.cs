namespace CCT.Timestamps.App
{
    public class AlterarPedidoUseCase
    {
        private IPedidoDados PedDados { get; }
        private ITimestampProvider Tms { get; }

        public AlterarPedidoUseCase(IPedidoDados ped, ITimestampProvider tms)
        {
            PedDados = ped;
            Tms = tms;
        }

        public Pedido Executar(int numero, string descricao)
        {
            var pedido = PedDados.Obter(numero);
            pedido.Descricao = descricao;
            pedido.DataUltimaAlteracao = Tms.Now();

            PedDados.Alterar(pedido);
            return pedido;
        }
    }
}
