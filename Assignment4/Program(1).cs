using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = new Employee[1];

            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter City: ");
                string city = Console.ReadLine();

                Console.WriteLine("Enter Contact NO.: ");
                int cntNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Salary: ");
                decimal sal = decimal.Parse(Console.ReadLine());

                arr[i] = new Employee(name, city, cntNo, sal);
            }
            Console.WriteLine("----");
            foreach (Employee e in arr)
            {
                e.DisplayEmp();
            }

            decimal temp = arr[0].EmpSalary;
            int tempid = -1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (temp < arr[i].EmpSalary)
                {
                    temp = arr[i].EmpSalary;
                    tempid = arr[i].EmpNo;

                }
            }
            Console.WriteLine("----");
            for (int i = 0; i < arr.Length; i++)
            {
                //int.TryParse(Console.ReadLine(), out j);
                if (arr[i].EmpNo == tempid)
                {
                    arr[i].DisplayEmp();
                    break;
                }

            }
            Console.WriteLine("----");
            
            Console.WriteLine("Enter Employee ID.: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("----");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].EmpNo == id)
                {
                    arr[i].DisplayEmp();
                    break;
                }

            }
            foreach (Employee e in arr)
            {
                if (e.EmpNo == id)
                    e.DisplayEmp();
            }



        }
    }
    class Employee
    {
        public Employee(string empName, string empAdd, int empContact, decimal empSalary)
        {
            this.EmpName = empName;
            empNo = ++count;
            this.EmpAdd = empAdd;
            this.EmpContact = empContact;
            this.EmpSalary = empSalary;
        }
        private int empNo;
        private static int count;
        private string empName;
        private string empAdd;
        private int empContact;
        private decimal empSalary;

        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public string EmpName
        {
            set
            {
                empName = value;
            }
            get
            {
                return empName;
            }

        }


        public string EmpAdd
        {
            set
            {
                empAdd = value;
            }
            get
            {
                return empAdd;
            }

        }
        public int EmpContact
        {
            set
            {
                empContact = value;
            }
            get
            {
                return empContact;
            }
        }
        public decimal EmpSalary
        {
            set
            {
                empSalary = value;
            }
            get
            {
                return empSalary;
            }
        }

        public void DisplayEmp()
        {
            Console.WriteLine("ID: " + EmpNo + " name: " + EmpName + " Address: " + EmpAdd + " Contact: " + EmpContact + " Salary: " + EmpSalary);
            Console.ReadLine();
        }


    }
}

