using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee person1 = new Employee()
            {
                Id = 1
               
            };

            Employee person2 = new Employee()
            {
                Id = 2
            };

            Console.WriteLine(person1 == person2);
            Console.ReadLine();
        }

    }

}
