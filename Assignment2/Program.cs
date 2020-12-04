using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager emp = new Manager("San", 10, 18000, "GM");
            Console.WriteLine(emp.EMPNO + " " + emp.NAME + " " + emp.DEPTNO + " " + emp.BASIC + " " + emp.DESIGNATION);
            Console.ReadLine();
        }
    }
    public abstract class Employee
    {
        private string name;
        private int empNo;
        private short deptNo;
        protected decimal basic;
        private static int latestValue;


        public abstract decimal calcNetSalary(int empNo, decimal basic);

        public Employee(string name, short deptNo, decimal basic)
        {
            this.NAME = name;
            this.DEPTNO = deptNo;
            this.BASIC = basic;
            empNo = ++latestValue;

        }
        public string NAME
        {
            set
            {
                if (value != " ")
                    name = value;
                else
                    Console.WriteLine("Cannot Be Blank");
            }
            get
            {
                return name;
            }
        }

        public abstract decimal BASIC
        {
            set;
            get;

        }

        public int EMPNO
        {
            get
            {
                return empNo;
            }
        }

        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("It must Be greater than zero");
            }
            get
            {
                return deptNo;
            }
        }

    }

    public class Manager : Employee
    {

        private string designation;

        public Manager(string name, short deptNo, decimal BASIC, string designation) : base(name, deptNo, BASIC)
        {
            this.DESIGNATION = designation;
        }

        public string DESIGNATION
        {
            set
            {
                if (value != " ")
                    designation = value;
                else
                    Console.WriteLine("Designation cant be Empty");
            }
            get
            {
                return designation;
            }
        }

        public override decimal BASIC
        {
            set
            {
                if (value >= 10000 && value <= 100000)
                    basic = value;
                else
                    Console.WriteLine("out of range");

            }
            get
            {
                return basic;
            }
        }

        public override decimal calcNetSalary(int empNo, decimal basic)
        {
            return 12 * basic;
        }
    }

    public class GeneralManager : Manager
    {
        private string perks;

        public GeneralManager(string name, short deptNo, decimal basic, string designation, string perks) : base(name, deptNo, basic, designation)
        {
            this.PERKS = perks;

        }

        public string PERKS
        {
            set { perks = value; }
            get { return perks; }
        }

    }

    public class CEO : Employee
    {
        public CEO(string name, short deptNo, decimal basic) : base(name, deptNo, basic)
        {
            this.basic = basic;
        }
        public override decimal BASIC
        {
            set
            {
                if (value >= 100000 && value <= 1000000)
                    basic = value;
                else
                    Console.WriteLine("out of range");

            }
            get
            {
                return basic;
            }
        }

        public sealed override decimal calcNetSalary(int empNo, decimal basic)
        {
            return 12 * basic;
        }
    }
}
