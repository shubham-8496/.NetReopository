using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal: ");
            decimal p = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter year period: ");
            decimal r = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Rate of interest in %: ");
            decimal n = Convert.ToDecimal(Console.ReadLine());

            Func<decimal, decimal, decimal, decimal> Sterest = (a, b, c) => ((a * b * c) / 100);
            Console.WriteLine("Simple Interset is: " + Sterest(p, r, n));

            Console.ReadLine();
        }
    }
}