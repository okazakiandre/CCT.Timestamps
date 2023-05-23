namespace CCT.Timestamps.App
{
    public interface IPedidoDados
    {
        Pedido Obter(int numero);
        void Incluir(Pedido pedido);
        void Alterar(Pedido pedido);
    }
}
