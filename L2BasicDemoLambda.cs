using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicDemoLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = (Console.ReadLine());

            Console.WriteLine("Enter Deptno greater tha zero: ");
            short deptno = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter salary bt 1000 and 10000: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Employee emp = new Employee(name, salary, deptno);

            Func<Employee, decimal> em = (Employee a) => a.BASIC * 12;

            Console.WriteLine("Salary is: " + em(emp));
            Console.ReadLine();
        }
    }

    class Employee
    {

        public Employee(string name = "noname", decimal basic = 100000, short deptNo = 2)
        {
            this.NAME = name;
            empNo = ++latestVlaue;
            this.BASIC = basic;
            this.DEPTNO = deptNo;
        }

        private string name;
        private int empNo;
        private decimal basic;
        private short deptNo;
        private static int latestVlaue;

        public string NAME
        {
            set
            {
                if (value != " ")
                    name = value;
                else
                    Console.WriteLine("Name cannot be blank");
            }
            get
            {
                return name;
            }
        }
        public int EMPNO
        {
            get
            {
                return empNo;
            }
        }
        public decimal BASIC
        {
            set
            {
                if (value >= 1000 && value <= 10000)
                    basic = value;
                else
                    Console.WriteLine("out of range must be between 1000 and 10000");
            }
            get
            {
                return basic;
            }
        }
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Department number must be greater than zero");
            }
            get
            {
                return deptNo;
            }
        }



        public decimal GetNetSalary(int empNo, decimal basic)
        {
            return 12 * basic;
        }


    }
}