using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Employee o1 = new Employee("Amol", 10, 12346);
            Console.WriteLine("empId =" + Employee.empId +" "+ "empName =" + o1.NAME + " " + "deptno =" + o1.DEPTNO);
            Console.WriteLine("salary =" + o1.getNetSalary());
            Employee o2 = new Employee("whoamol", 5000);
            Console.WriteLine("empId =" +Employee.empId + " " + "empName =" +  o2.NAME + " " + "deptno =" +  o2.DEPTNO);
            Console.WriteLine("salary =" +o2.getNetSalary());
            Employee o3 = new Employee("whyAmol");
            Console.WriteLine("empId =" + Employee.empId + " " + "empName =" + o3.NAME + " " + "deptno =" +  o3.DEPTNO);
            Console.WriteLine("salary =" +o3.getNetSalary());
        }
    }

    public class Employee
    {
        private string name;
        public static int empId;
        private double basicSalary;
        private short deptNo;

        public Employee(string name="default name" ,short deptNo=69 , double basicSalary=10000)
        {
            this.NAME=name;
            this.BASICSALARY=basicSalary;
            this.DEPTNO=deptNo;
            empId++;

        }
       

        public decimal getNetSalary()
        {
           return (Decimal) ((basicSalary * 0.15 ) + basicSalary);
            
        }

        public string NAME
        {
            set
            {
                if(value!=" ")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return name;
            }
        }
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return deptNo;
            }
        }
        public double BASICSALARY
        {
            set
            {
                if (value > 3000 && value < 20000)
                {
                    basicSalary = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            get
            {
                return basicSalary;
            }
        }




    }
}
