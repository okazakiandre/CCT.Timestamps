namespace CCT.Timestamps.UnitTest
{
    [TestClass]
    public class IdempotenteTest
    {
        [TestMethod]
        public void DeveriaRetornarSempreOMesmoResultado()
        {
            var prod = new Produto { Preco = 100.0 };
            var res = prod.PrecoComTaxa(1.1);
            Assert.AreEqual(110.0, res);

            prod = new Produto { Preco = 200.0 };
            res = prod.PrecoComTaxa(1.2);
            Assert.AreEqual(240.0, res);
        }
    }

    public class Produto
    {
        public double Preco { get; set; }
        public double PrecoComTaxa(double taxa) => Math.Round(Preco * taxa, 2);
    }
}