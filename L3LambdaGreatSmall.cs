using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaGreatSmall
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            GreatSmall gs = new GreatSmall(no1, no2);


            //Func< int, int, bool> res = (a, b) => a > b ? true : false;
            //Console.WriteLine(res(no1, no2));

            Predicate<GreatSmall> functionGS = (GreatSmall ga) => (ga.No1 > ga.No2 ? true : false);
            Console.WriteLine(functionGS(gs));
            Console.ReadLine();

        }
    }
    class GreatSmall
    {
        public GreatSmall(int no1, int no2)
        {
            this.No1 = no1;
            this.No2 = no2;
        }
        private int no1;
        private int no2;

        public int No1
        {
            set
            {
                no1 = value;
            }
            get
            {
                return no1;
            }
        }
        public int No2
        {
            set
            {
                no2 = value;
            }
            get
            {
                return no2;
            }
        }
    }
}


