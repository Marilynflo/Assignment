using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee //creating employee class with id properties
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Employee person1, Employee person2) //using == overloading operators for comparison
        {
            if (person1 == person2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee person1, Employee person2)
        {
            if (person1 != person2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}