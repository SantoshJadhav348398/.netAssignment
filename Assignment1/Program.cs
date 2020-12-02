using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {

                Employee emp = new Employee("hesh", 123456, 10);
                Console.WriteLine("Employee Number:" + emp.EMPNO + "   employee name: " + emp.NAME + "   Basic salary: " + emp.BASIC + "    department number: " + emp.DEPTNO + "    Employee net salary: " + emp.GetNetSalary());

                Employee emp1 = new Employee("sidd", 123456);
                Console.WriteLine("Employee Number:" + emp1.EMPNO + "   employee name: " + emp1.NAME + "   Basic salary: " + emp1.BASIC + "    department number: " + emp1.DEPTNO + "    Employee net salary: " + emp1.GetNetSalary());


                Employee emp2 = new Employee("san");
                Console.WriteLine("Employee Number:" + emp2.EMPNO + "   employee name: " + emp2.NAME + "   Basic salary: " + emp2.BASIC + "    department number: " + emp2.DEPTNO + "    Employee net salary: " + emp2.GetNetSalary());

                Employee emp3 = new Employee();
                Console.WriteLine("Employee Number:" + emp3.EMPNO + "   employee name: " + emp3.NAME + "   Basic salary: " + emp3.BASIC + "    department number: " + emp3.DEPTNO + "    Employee net salary: " + emp3.GetNetSalary());

                Console.ReadLine();
            }
        }
        class Employee
        {
            //CONSTROCTOR

            public Employee(string name, decimal basic, short deptNo)
            {
                this.NAME = name;
                empNo = ++Latest;
                this.BASIC = basic;
                this.DEPTNO = deptNo;
            }
            public Employee(string name, decimal basic)
            {
                this.NAME = name;
                empNo = ++Latest;
                this.BASIC = basic;
                this.DEPTNO = 10;
            }
            public Employee(string name)
            {
                this.NAME = name;
                empNo = ++Latest;
                this.BASIC = 123465;
                this.DEPTNO = 10;

            }
            public Employee()
            {
                this.NAME = "su";
                empNo = ++Latest;
                this.BASIC = 123465;
                this.DEPTNO = 10;

            }
            private string name;
            private int empNo;
            private decimal basic;
            private short deptNo;
            private static int Latest;

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
                set
                {
                    empNo = value;
                }
                get
                {
                    return empNo;
                }
            }
            public decimal BASIC
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

            //METHODS

            public decimal GetNetSalary()
            {
                return 12 * basic;
            }


        }
 }

