using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                /*string twenty = "20";
                string eighteen = "040";
                if (twenty == eighteen)
                {
                    Console.WriteLine("20 is greater than 18");
                }
                else
                {
                    Console.WriteLine("no");
                }*/

                Console.WriteLine("Enter number:");

                // Create a string variable and get user input from the keyboard and store it in the variable
                string numberOne = Console.ReadLine();

                double doubleValOne = Convert.ToDouble(numberOne);

                Console.WriteLine("Enter nuber to devide with:");
                string numberTwo = Console.ReadLine();

                double doubleValTwo = Convert.ToDouble(numberTwo);

                double division = doubleValOne / doubleValTwo;

                Console.WriteLine(division);
                Console.ReadLine();
            }
        }    
    }
}
