using System;

namespace GeneratePrimes.Console
{
    public class PrimeGenerator
    {
        private static bool[] f;
        private static int[] primes;

        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue < 2)
            {
                return new int[0];
            }
            else
            {
                InitializeArrayOfIntegers(maxValue);
                CrossOutMultiples();
                PutUncrossedIntegersIntoResult();
                return primes;
            }
        }

        private static void PutUncrossedIntegersIntoResult()
        {
            int i;
            int j;
            int count = 0;
            for (i = 0; i < f.Length; i++)
            {
                if (f[i])
                {
                    count++;
                }
            }

            primes = new int[count];

            for (i = 0, j = 0; i < f.Length; i++)
            {
                if (f[i])
                {
                    primes[j++] = i;
                }
            }
        }

        private static void CrossOutMultiples()
        {
            int i;
            int j;
            for (i = 2; i < Math.Sqrt(f.Length) + 1; i++)
            {
                if (f[i])
                {
                    for (j = 2 * i; j < f.Length; j += i)
                    {
                        f[j] = false;
                    }
                }
            }
        }

        private static void InitializeArrayOfIntegers(int maxValue)
        {
            f = new bool[maxValue + 1];
            int i;

            for (i = 0; i < f.Length; i++)
            {
                f[i] = true;
            }

            f[0] = f[1] = false;
        }
    }
}