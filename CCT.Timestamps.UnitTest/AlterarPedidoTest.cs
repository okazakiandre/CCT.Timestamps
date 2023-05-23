using CCT.Timestamps.App;
using Moq;

namespace CCT.Timestamps.UnitTest
{
    [TestClass]
    public class AlterarPedidoTest
    {
        [TestMethod]
        public void DeveriaAlterarPedido()
        {
            var descricao = "pedido alterado";
            var dataCriacao = new DateTime(2023, 1, 4);
            var pedidoCadastrado = new Pedido
            {
                Numero = 111,
                Descricao = "novo pedido",
                DataCriacao = dataCriacao
            };
            var mockPed = new Mock<IPedidoDados>();
            mockPed.Setup(p => p.Obter(It.IsAny<int>())).Returns(pedidoCadastrado);
            var mockTms = new Mock<ITimestampProvider>();
            mockTms.Setup(t => t.Now()).Returns(new DateTime(2023, 2, 2));
            var usc = new AlterarPedidoUseCase(mockPed.Object, mockTms.Object);

            var res = usc.Executar(111, descricao);

            mockPed.Verify(p => p.Alterar(It.IsAny<Pedido>()), Times.Once);
            Assert.AreEqual(descricao, res.Descricao);
            Assert.AreEqual(dataCriacao, res.DataCriacao);
            Assert.AreEqual(new DateTime(2023, 2, 2), res.DataUltimaAlteracao);
        }
    }
}