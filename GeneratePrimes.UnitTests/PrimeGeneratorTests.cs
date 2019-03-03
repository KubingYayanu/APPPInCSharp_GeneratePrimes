using GeneratePrimes.Console;
using NUnit.Framework;

namespace GeneratePrimes.UnitTests
{
    [TestFixture]
    public class PrimeGeneratorTests
    {
        [Test]
        public void GeneratePrimeNumbers_MaxValueIs0_ReturnNullArray()
        {
            int[] nullArray = PrimeGenerator.GeneratePrimeNumbers(0);
            Assert.That(nullArray.Length, Is.EqualTo(0));
        }

        [Test]
        public void GeneratePrimeNumbers_MaxValueIs1_Return1Prime()
        {
            int[] minArray = PrimeGenerator.GeneratePrimeNumbers(2);
            Assert.That(minArray.Length, Is.EqualTo(1));
            Assert.That(minArray[0], Is.EqualTo(2));
        }

        [Test]
        public void GeneratePrimeNumbers_MaxValueIs3_Return2Prime()
        {
            int[] threeArray = PrimeGenerator.GeneratePrimeNumbers(3);
            Assert.That(threeArray.Length, Is.EqualTo(2));
            Assert.That(threeArray[0], Is.EqualTo(2));
            Assert.That(threeArray[1], Is.EqualTo(3));
        }

        [Test]
        public void GeneratePrimeNumbers_MaxValueIs100_Return25Prime()
        {
            int[] centArray = PrimeGenerator.GeneratePrimeNumbers(100);
            Assert.That(centArray.Length, Is.EqualTo(25));
            Assert.That(centArray[24], Is.EqualTo(97));
        }
    }
}