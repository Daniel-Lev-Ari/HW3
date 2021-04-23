using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public static class CalcDateTime
    {
        public static int DateDif(DateTime d1, DateTime d2)
        {
            TimeSpan difference = d1.Date - d2.Date;
            int days = (int)difference.TotalDays;
            Console.WriteLine($"DateDif return num of days: {days}");
            return days;
        }
        public static DateTime AddDayToDate(DateTime d,uint days)
        {
            DateTime NewDate = d.AddDays(days);
            return NewDate;
        }
        

    }
}
