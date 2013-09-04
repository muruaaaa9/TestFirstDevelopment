using NUnit.Framework;

namespace Domain.Tests.AdhocTests
{
    [TestFixture]
    public class MyTestFixture
    {
        [Test]
        public void MyFirstTest()
        {
            const int result = 2 + 2;

            Assert.AreEqual(4, result);
        }
    }
}
