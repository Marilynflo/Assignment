using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums101
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What day is it today?"); // asking for a user input
                string today = Console.ReadLine();
                Day inputDay = (Day)Enum.Parse(typeof(Day), today); 
              
                {
                    Console.WriteLine("Today is " + inputDay); //writing in console of the user input 
                }


            }
            catch (FormatException) //using try/catch block if any error occurs
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }
    }
}
