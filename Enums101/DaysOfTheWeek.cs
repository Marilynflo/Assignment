using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums101
{
    public class DaysOfTheWeek // creating an enum days of the week
    {
        public Day Day { get; set; } //property


    }
    public enum Day  //assigning value of the days of the week
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
}