using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructureProject1
{
    public static class DateGenerator
    {

        public static DateTime GetDate()
        {
            var rnd = new Random();
            var days = (int)(Convert.ToDateTime("31.12.1997") - Convert.ToDateTime("01.01.1995")).TotalDays;

            return Convert.ToDateTime("01.01.1995").AddDays(rnd.Next(0, days));
        }
    }
}
