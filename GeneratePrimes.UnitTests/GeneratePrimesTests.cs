
using NUnit.Framework;

namespace GeneratePrimes.UnitTests
{
    [TestFixture]
    public class GeneratePrimesTests
    {
        [Test]
        public void TestPrimess()
        {
            int[] nullArray = Console.GeneratePrimes.GeneratePrimeNumbers(0);
            Assert.That(nullArray.Length, Is.EqualTo(0));

            int[] minArray = Console.GeneratePrimes.GeneratePrimeNumbers(2);
            Assert.That(minArray.Length, Is.EqualTo(1));
            Assert.That(minArray[0], Is.EqualTo(2));

            int[] threeArray = Console.GeneratePrimes.GeneratePrimeNumbers(3);
            Assert.That(threeArray.Length, Is.EqualTo(2));
            Assert.That(threeArray[0], Is.EqualTo(2));
            Assert.That(threeArray[1], Is.EqualTo(3));

            int[] centArray = Console.GeneratePrimes.GeneratePrimeNumbers(100);
            Assert.That(centArray.Length, Is.EqualTo(25));
            Assert.That(centArray[24], Is.EqualTo(97));
        }
    }
}