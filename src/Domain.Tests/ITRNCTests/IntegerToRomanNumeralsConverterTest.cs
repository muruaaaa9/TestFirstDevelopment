using Domain.IntegerToRomanNumerals;
using NUnit.Framework;

namespace Domain.Tests.ITRNCTests
{
    [TestFixture]
    public class IntegerToRomanNumeralsConverterTest
    {
        public IntegerToRomanNumeralConverter IntegerToRomanNumeralConverter;

        [SetUp]
        public void SetUp()
        {
            IntegerToRomanNumeralConverter = new IntegerToRomanNumeralConverter();
        }
        
        [Test]
        public void ShouldReturnIWhenPassOne()
        {
            var romanNumeralOne = IntegerToRomanNumeralConverter.ToRomanNumeralString(1);
            Assert.That(romanNumeralOne, Is.EqualTo("I"));
        }
        
        [Test]
        public void ShouldReturnIIWhenPassTwo()
        {
            var romanNumeralOne = IntegerToRomanNumeralConverter.ToRomanNumeralString(2);
            Assert.That(romanNumeralOne, Is.EqualTo("II"));
        }

        [Test]
        public void ShouldReturnVFromDictionaryWhenPassFive()
        {
            var romanNumeralFiver = IntegerToRomanNumeralConverter.ToRomanNumeralString(5);
            Assert.That(romanNumeralFiver, Is.EqualTo("V"));
        }

        [Test]
        public void ShouldReturnVFromDictionaryWhenPassSeven()
        {
            var romanNumeralSeven = IntegerToRomanNumeralConverter.ToRomanNumeralString(7);
            Assert.That(romanNumeralSeven, Is.EqualTo("VII"));
        }

        [Test]
        public void ShouldReturnVFromDictionaryWhenPassNine()
        {
            var romanNumeral = IntegerToRomanNumeralConverter.ToRomanNumeralString(9);
            Assert.That(romanNumeral, Is.EqualTo("IX"));
        }

        [Test]
        public void ShouldReturnVFromDictionaryWhenPassTen()
        {
            var romanNumeral = IntegerToRomanNumeralConverter.ToRomanNumeralString(10);
            Assert.That(romanNumeral, Is.EqualTo("X"));
        }

        [Test]
        public void ShouldReturnXIIIWhenPassThirteen()
        {
            var romanNumeral = IntegerToRomanNumeralConverter.ToRomanNumeralString(13);
            Assert.That(romanNumeral, Is.EqualTo("XIII"));
        }

        [Test]
        public void ShouldReturnXIIIWhenPassFourteen()
        {
            var romanNumeral = IntegerToRomanNumeralConverter.ToRomanNumeralString(14);
            Assert.That(romanNumeral, Is.EqualTo("XIV"));
        }

        [Test]
        public void ShouldReturnXXWhenPassTwenty()
        {
            var romanNumeral = IntegerToRomanNumeralConverter.ToRomanNumeralString(20);
            Assert.That(romanNumeral, Is.EqualTo("XX"));
        }

        [Test]
        public void ShouldReturnXXWhenPassFortyFive()
        {
            var romanNumeral = IntegerToRomanNumeralConverter.ToRomanNumeralString(45);
            Assert.That(romanNumeral, Is.EqualTo("XXXXV"));
        }

        [Test]
        public void ShouldReturnXXWhenPassFifty()
        {
            var romanNumeral = IntegerToRomanNumeralConverter.ToRomanNumeralString(50);
            Assert.That(romanNumeral, Is.EqualTo("L"));
        }
    }
}