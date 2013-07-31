using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domain.Tests
{
    [TestFixture]
    public class NumberToEnglishWords
    {
        [Test]
        public void NumberToEnglishShouldReturnOne()
        {
            string actual = English.NumberToEnglish(1);
            Assert.AreEqual("one", actual, "Expected the result to be \"one\"");
        }
        [Test]
        public void NumberToEnglishShouldReturnTwo()
        {
            string actual = English.NumberToEnglish(2);
            Assert.AreEqual("two", actual, "Expected the result to be \"two\"");
        }

        [Test]
        public void NumberToEnglishShouldReturnTwentyOne()
        {
            string actual = English.NumberToEnglish(21);
            Assert.AreEqual("twenty one", actual, "Expected the result to be \"twenty one\"");
        } 
        
        [Test]
        public void NumberToEnglishShouldReturnThirty()
        {
            string actual = English.NumberToEnglish(30);
            Assert.AreEqual("thirty", actual, "Expected the result to be \"thirty\"");
        }
        
        [Test]
        public void NumberToEnglishShouldReturnFortyOne()
        {
            string actual = English.NumberToEnglish(41);
            Assert.AreEqual("forty one", actual, "Expected the result to be \"forty one\"");
        } 
        
        [Test]
        public void NumberToEnglishShouldReturnHunderdAndOne()
        {
            string actual = English.NumberToEnglish(101);
            Assert.AreEqual("one hundred and one", actual, "Expected the result to be \"hundred and one\"");
        } 
        
        [Test, Ignore("this needs to be refactored later")]
        public void NumberToEnglishShouldReturnTwoHunderdAndOne()
        {
            string actual = English.NumberToEnglish(201);
            Assert.AreEqual("two hundred and one", actual, "Expected the result to be \"hundred and one\"");
        }
    }
}
