using System;
using System.Diagnostics;

namespace BigONotationPartial
{
    class Exponential
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Exponential exponential = new Exponential();
            ExponentialExampleType exponentialExampleType = ExponentialExampleType.Fibonacci;
            switch (exponentialExampleType)
            {
                case ExponentialExampleType.Fibonacci:
                    int numt =150; //8 40 80
                        exponential.Fibonacci(numt);
                    break;
            }
            Console.WriteLine("Time elapsed: {0:0.00} seconds", Math.Round(stopWatch.ElapsedMilliseconds / 1000.0, 2));
            Console.ReadLine();
        }

        /// Complexity: O(2^N)
        internal void Fibonacci(long n)
        {
            long primero = 0,segundo=1,i=0,ii=0;
            while (i<=n)
            {
                if (i == 0)
                {
                    Console.WriteLine(" fibonacci {0} = {1} ", i, primero);
                }
                else
                {
                    ii = primero;
                    primero = segundo;
                    segundo = ii + primero;
                    Console.WriteLine(" fibonacci {0} = {1} ", i, primero);
                }
                i++;
            }
            
            
        }
    }
}


