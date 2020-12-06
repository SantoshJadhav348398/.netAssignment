using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4C
{
    class Program
    {
        static void Main(string[] args)
        {
            student[] arr = new student[2];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter name: ");
                string name = (Console.ReadLine());

                Console.WriteLine("Enter Roll no: ");
                int rollno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter marks: ");
                decimal mrks = Convert.ToDecimal(Console.ReadLine());

                arr[i] = new student(name, rollno, mrks);
            }

            foreach (student s in arr)
            {
                Console.WriteLine(s.DisplayStud());
            }
            Console.ReadLine();

        }
        struct student
        {
            public student(string name = "noname", int rollNo = 0, decimal marks = 0)
            {
                this.name = "enull";
                this.rollNo = 0;
                this.marks = 100;

                this.Name = name;
                this.RollNo = rollNo;
                this.Marks = marks;
            }

            private string name;
            private int rollNo;
            private decimal marks;


            public string Name
            {
                set
                {
                    if (value != " ")
                    {
                        name = value;
                    }
                    else
                        Console.WriteLine("Name cannot be blank");
                }
                get
                {
                    return name;
                }
            }
            public int RollNo
            {
                set
                {
                    if (value > 0)
                    {
                        rollNo = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid roll no.");
                    }
                }
                get
                {
                    return rollNo;
                }
            }
            public decimal Marks
            {
                set
                {
                    if (value > -1 && value < 101)
                    {
                        marks = value;
                    }
                    else
                    {
                        Console.WriteLine("invalid Marks ");
                    }
                }
                get
                {
                    return marks;
                }
            }

            public void InsertStud()
            {
                Console.WriteLine("Enter name: ");
                Name = (Console.ReadLine());

                Console.WriteLine("Enter Roll no: ");
                RollNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter marks: ");
                Marks = Convert.ToDecimal(Console.ReadLine());

            }

            public string DisplayStud()
            {
                return ("Rollno: " + RollNo + " Name: " + Name + " Marks: " + Marks);
            }

        }
    }
}
