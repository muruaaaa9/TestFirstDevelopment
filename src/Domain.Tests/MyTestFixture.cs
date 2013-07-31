using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domain.Tests
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
