using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of batches: ");
            int batch = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of students: ");
            int stud = int.Parse(Console.ReadLine());

            int[,] arr = new int[batch,stud];

            for (int i = 0; i < batch; i++)
            {

                for (int j = 0; j < stud; j++)
                {
                    Console.WriteLine("Enter Marks ");
                    //int.TryParse(Console.ReadLine(), out arr[i,j]);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < batch; i++)
            {
                for (int j = 0; j < stud; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
                
            }
            Console.ReadLine();
        }
    }
}

