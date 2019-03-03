using System;

namespace GeneratePrimes.Console
{
    public class PrimeGenerator
    {
        private static bool[] isCrossed;
        private static int[] result;

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
                return result;
            }
        }

        private static void InitializeArrayOfIntegers(int maxValue)
        {
            isCrossed = new bool[maxValue + 1];
            for (int i = 2; i < isCrossed.Length; i++)
            {
                isCrossed[i] = false;
            }
        }

        private static void CrossOutMultiples()
        {
            for (int i = 2; i < Math.Sqrt(isCrossed.Length) + 1; i++)
            {
                if (NotCrossed(i))
                {
                    CrossOutputMultiplesOf(i);
                }
            }
        }

        private static void CrossOutputMultiplesOf(int i)
        {
            for (int multiple = 2 * i; multiple < isCrossed.Length; multiple += i)
            {
                isCrossed[multiple] = true;
            }
        }

        private static bool NotCrossed(int i)
        {
            return isCrossed[i] == false;
        }

        private static void PutUncrossedIntegersIntoResult()
        {
            int i;
            int j;
            int count = 0;
            for (i = 2; i < isCrossed.Length; i++)
            {
                if (NotCrossed(i))
                {
                    count++;
                }
            }

            result = new int[count];

            for (i = 2, j = 0; i < isCrossed.Length; i++)
            {
                if (NotCrossed(i))
                {
                    result[j++] = i;
                }
            }
        }
    }
}