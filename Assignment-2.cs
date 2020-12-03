using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Details");
            Console.WriteLine("Manager");
            Manager m = new Manager("amol", 2, 50000, "Manager");
            Console.WriteLine("Employee ID : " + " " + m.EMPNO);
            Console.WriteLine("Name : " + " " + m.NAME);
            Console.WriteLine("Dept no : " + " " + m.DEPTNO);
            Console.WriteLine("Net salary : " + " " + m.CalcNetSalary());
            Console.WriteLine("Designation : " + " " + m.DESIGNATION);

            Console.WriteLine(" ");
            Console.WriteLine("General Manager");
            GeneralManager g = new GeneralManager("whoIsAmol", 3, 60000, "General Manager", "perk1");
            Console.WriteLine("Employee ID : " + " " + g.EMPNO);
            Console.WriteLine("Name : " + " " + g.NAME);
            Console.WriteLine("Dept no : " + " " + g.DEPTNO);
            Console.WriteLine("Net Salary : " + " " + g.CalcNetSalary());
            Console.WriteLine("Designation : " + " " + g.DESIGNATION);


            Console.WriteLine(" ");
            Console.WriteLine("CEO");
            CEO c = new CEO("whyIsAmol", 4, 70000);
            Console.WriteLine("Employee ID : " + " " + c.EMPNO);
            Console.WriteLine("Name : " + " " + c.NAME);
            Console.WriteLine("Dept no : " + " " + c.DEPTNO);
            Console.WriteLine("Net salary : " + " " + c.CalcNetSalary());

            Console.ReadLine();

        }
    }

    public abstract class Employee
    {
        private String Name;
        private readonly int Empno;
        private short DeptNo;
        private decimal Basic;
        private static int counter = 1;
        public abstract decimal CalcNetSalary();

        #region Properties
        public String NAME
        {
            set
            {
                if (value != " ")
                {
                    Name = value;
                }
            }

            get
            {
                return Name;

            }
        }

        public int EMPNO
        {

            get
            {
                return Empno;
            }

        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }

            }
            get { return DeptNo; }

        }

        public abstract decimal BASIC
        {
            set;
            get;

        }

        public Employee(string Name = "Employee default", short DeptNo = 1, decimal Basic = 50000)
        {
            this.NAME = Name;
            this.DEPTNO = DeptNo;
            this.BASIC = Basic;

            Empno = counter++;
        }



        #endregion


        #region for test cases


        public Employee()
        {
            Empno = counter++;
        }

        #endregion


    }


    public class Manager : Employee
    {
        public override decimal BASIC
        {
            get;
            set;
        }
        private String Designation;

        #region Properties Manager
        public String DESIGNATION
        {
            set
            {
                if (value != " ")
                {
                    Designation = value;
                }
            }

            get
            {
                return Designation;
            }
        }



        #endregion

        public override decimal CalcNetSalary()
        {
            decimal Netsalary = BASIC + (BASIC / 4);
            return Netsalary;
        }

        public Manager(string Name = "Employee default", short DeptNo = 2, decimal Basic = 60000, String Designation = "Manager") : base(Name, DeptNo, Basic)
        {
            
            this.DESIGNATION = Designation;

        }


    }


    public class GeneralManager : Manager
    {
        private string Perks;

        public string PERKS
        {
            set;
            get;

        }

        public GeneralManager(string Name = "Employee default", short DeptNo = 3, decimal Basic = 70000, String Designation = "General Manager", String Perks = "Perks") : base(Name, DeptNo, Basic, Designation)
        {
           
            this.PERKS = Perks;


        }


    }


    public class CEO : Employee
    {
        public override decimal BASIC
        {
            get;
            set;
        }

        public CEO(string Name = "Employee default", short DeptNo = 4, decimal Basic = 80000) : base(Name, DeptNo, Basic)
        {
           


        }


        public override sealed decimal CalcNetSalary()
        {
            decimal Netsalary = BASIC + (BASIC / 4);
            return Netsalary;
        }




    }
}
