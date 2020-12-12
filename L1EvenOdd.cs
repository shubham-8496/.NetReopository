using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaAssignments
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Predicate<int> evnOdd = a => a % 2 == 0 ? true : false;

            Console.WriteLine(evnOdd(n1));
            Console.ReadLine();
        }

    }
}

