using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_zest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            long fctrl = Factorial(n);

            Console.WriteLine("The factorial of {0} equals {1}.", n, fctrl);

            Console.ReadKey();
        }
        /***************************************************/
        static long Factorial(int n)
        {
            //0! = 1 nad 1! = 1
            if (n <= 1) return 1;
            //in other cases, call the function recursively with the previous
            // number as its argument (n-1) and multiply the outcume by n 
            return n * Factorial(n - 1);
        }
    }
}
