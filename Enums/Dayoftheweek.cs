using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public class Dayoftheweek
    {
        public Day Day { get; set; } //property
    }
    public enum Day //assigning value to the variable created
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
       
    }
}
