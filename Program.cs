using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, factorial = 1;
            Console.WriteLine("Enter a nonnegative integer");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)

                Console.WriteLine("Incorrect input, please write a nonnegative integer ");

            else if (number <= 1)
                Console.WriteLine("{0}! = {1}", number, factorial);
            else
            {
                for (int counter = number; counter >= 2; counter--)

                {
                    factorial = factorial * counter;
                }


                Console.WriteLine("{0}! = {1}", number, factorial);

                Console.ReadLine();



            }
        }
    }
}


