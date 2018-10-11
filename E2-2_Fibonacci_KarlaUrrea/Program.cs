using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2_Fibonacci_KarlaUrrea
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesFibonacci operacion = new OperacionesFibonacci();


                Console.WriteLine("Numero en la sucesion fibonacci");
                int n = Int32.Parse(Console.ReadLine());
            

            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);


            
                Console.WriteLine("Fibbonacci de {0}= {1} ", n, operacion.FibonacciRecursividad(n));
            

            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Tiempo: " + stop.Subtract(start).TotalMilliseconds);


            Console.WriteLine();


            TimeSpan parar;
            TimeSpan comenzar = new TimeSpan(DateTime.Now.Ticks);

            
                Console.WriteLine("Fibonacci de {0}= {1} ", n, operacion.Fibonacci(n));
           

            parar = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("Tiempo: " + parar.Subtract(comenzar).TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
