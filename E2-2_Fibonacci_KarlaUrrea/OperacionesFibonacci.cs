using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2_Fibonacci_KarlaUrrea
{
    class OperacionesFibonacci
    {
        public OperacionesFibonacci() { }



        public int Fibonacci(int n)
        {
            int nFibonacci = 1;
            int x1=1,x2=1;

            if (n>1)
            {
              
                for (int i = 2; i <= n; i++)
                {
                    nFibonacci=x1+x2;
                    x2= x1;
                    x1 = nFibonacci;
                    
                }
            }

            return nFibonacci;
        }

        public int FibonacciRecursividad(int n)
        {
            if ((n == 0) || (n == 1))
                return 1;
            else
                return FibonacciRecursividad(n - 1) + FibonacciRecursividad(n - 2);
        }
    }
}
