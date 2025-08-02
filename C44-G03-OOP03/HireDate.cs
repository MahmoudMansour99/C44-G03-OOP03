using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP03
{
    internal class HireDate
    {
        #region Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion

        #region Constructor
        public HireDate(int day, int month, int year)
        {
            if (day < 1 || day > 31)
                Console.WriteLine("Day must be between 1 and 31");

            if (month < 1 || month > 12)
                Console.WriteLine("Month must be between 1 and 12");

            if (year < 1950 || year > DateTime.Now.Year)
                Console.WriteLine("Year is out of valid range");

            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
        #endregion
    }
}
