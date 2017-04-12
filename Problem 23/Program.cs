using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NonAbundantSums());
            Console.Read();
        }

        private static int NonAbundantSums()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<int> abundantNumbers = new List<int>();
            List<int> sumOfTwoAbundant = new List<int>();
            int divisor = 0;
            int sum = 0;

            for (int i = 12; i < 28123; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        divisor += j;
                    }
                }
                if (divisor > i)
                {
                    abundantNumbers.Add(i);
                }
                divisor = 0;
            }

            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = 0; j < abundantNumbers.Count; j++)
                {

                    sum = abundantNumbers[i] + abundantNumbers[j];
                    sumOfTwoAbundant.Add(sum);

                }
            }

            sum = 0;
            sumOfTwoAbundant = sumOfTwoAbundant.Distinct().ToList();

            for (int i = 0; i < 28123; i++)
            {
                if (!sumOfTwoAbundant.Contains(i))
                    sum += i;
            }

            watch.Stop();
            return sum;

        }
    }
}
