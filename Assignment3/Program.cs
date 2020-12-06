using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment3
{
        class Program
        {
            static void Main()
            {
                Employee emp = new Manager("Sandy", 10, 18000, "GM");
                Console.WriteLine(emp.EMPNO + " " + emp.NAME + " " + emp.DEPTNO + " " + emp.BASIC);
                Console.ReadLine();

                Manager emp1 = new Manager("San", 10, 18000, "GM");
                Console.WriteLine(emp1.EMPNO + " " + emp1.NAME + " " + emp1.DEPTNO + " " + emp1.BASIC + " " + emp1.DESIGNATION);
                Console.ReadLine();

                GeneralManager emp2 = new GeneralManager("Sidd", 10, 18000, "GM", "Allowed");
                Console.WriteLine(emp2.EMPNO + " " + emp2.NAME + " " + emp2.DEPTNO + " " + emp2.BASIC + " " + emp2.DESIGNATION + " " + emp2.PERKS);
                Console.ReadLine();

                Employee emp3 = new CEO("Sanjit", 10);
                Console.WriteLine(emp3.EMPNO + " " + emp3.NAME + " " + emp3.DEPTNO + " " + emp3.BASIC);
                Console.ReadLine();

                Employee o1 = new Manager();
                DBFunctions(o1);
                Console.ReadLine();

                Employee o2 = new CEO();
                DBFunctions(o2);
                Console.ReadLine();


            }
            static void DBFunctions(IDbFunctions oIDb)
            {
                oIDb.Insert();
                oIDb.Delete();
                oIDb.Update();
            }
        }



        public interface IDbFunctions
        {
            void Insert();
            void Update();

            void Delete();

        }

        public abstract class Employee : IDbFunctions
        {
            private string name;
            private int empNo;
            private short deptNo;
            protected decimal basic;
            private static int latestValue;


            public abstract decimal calcNetSalary(int empNo, decimal basic);
            public abstract void Insert();
            public abstract void Update();
            public abstract void Delete();

            public Employee(string name = "NoName", short deptNo = 01, decimal basic = 10000)
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

        public class Manager : Employee, IDbFunctions
        {

            private string designation;

            public Manager(string name = "NoName", short deptNo = 01, decimal basic = 10000, string designation = "M") : base(name, deptNo, basic)
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

            public override void Delete()
            {
                Console.WriteLine("Manager Delete!");
            }

            public override void Insert()
            {
                Console.WriteLine("Manager Insert!");
            }

            public override void Update()
            {
                Console.WriteLine("Manager Update!");
            }
        }

        public class GeneralManager : Manager, IDbFunctions
        {
            private string perks;

            public GeneralManager(string name = "NoName", short deptNo = 01, decimal basic = 10000, string designation = "GM", string perks = "Not Allowed") : base(name, deptNo, basic, designation)
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
            public CEO(string name = "NoName", short deptNo = 01, decimal basic = 10000) : base(name, deptNo, basic)
            {
                this.basic = basic;
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

            public sealed override decimal calcNetSalary(int empNo, decimal basic)
            {
                return 12 * basic;
            }

            public override void Delete()
            {
                Console.WriteLine("CEO Delete!");
            }

            public override void Insert()
            {
                Console.WriteLine("CEO Insert!");
            }

            public override void Update()
            {
                Console.WriteLine("CEO Update!");
            }
        }
    }