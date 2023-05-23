using CCT.Timestamps.App;
using Moq;

namespace CCT.Timestamps.UnitTest
{
    [TestClass]
    public class IncluirPedidoTest
    {
        [TestMethod]
        public void DeveriaCriarNovoPedido()
        {
            var descricao = "Novo Pedido";
            var mockPed = new Mock<IPedidoDados>();
            var usc = new IncluirPedidoUseCase(mockPed.Object);

            var res = usc.Executar(descricao);

            mockPed.Verify(p => p.Incluir(It.IsAny<Pedido>()), Times.Once);
            Assert.AreEqual(descricao, res.Descricao);
            Assert.AreEqual(DateTime.Today, res.DataCriacao);
        }
    }
}