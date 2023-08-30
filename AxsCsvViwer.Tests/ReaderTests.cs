using AxsCsvViewer.Services;

namespace AxsCsvViwer.Tests
{
    [TestFixture]
    internal class ReaderTests
    {
        private IReader _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new Reader();
        }

        [Test]
        public void Read_HappyPath()
        {
            var result = _sut.Read("./Data/testSale.csv");
            Assert.AreEqual("941670467:21170491", result.First().transaction_id);
            Assert.AreEqual("FIRSTFIELD", result.Last().unique_id);
            Assert.AreEqual("LASTFIELD", result.Last().merch_component_name);
        }
    }
}
