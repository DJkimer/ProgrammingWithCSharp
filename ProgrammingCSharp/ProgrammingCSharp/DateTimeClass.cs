using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingCSharp
{
    class DateTimeClass
    {
        public void Method()
        {
            DateTime dateTime = new DateTime(2020, 03, 16,15,3,24); //16/03/2020 15:03:24
            DateTime dateTime2 = DateTime.MinValue; // 01/01/0001 00:00:00
            DateTime dateTime3 = DateTime.MaxValue; // 12/31/9999 11:59:59
            DateTime dateTime4 = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(3, 3, 24);
            DateTime resultDatTime = dateTime.Subtract(timeSpan); //16/03/2020 12:00:00
            TimeSpan timeSpanResult = dateTime.Subtract(dateTime2); //16/03/2020 12:00:00

        }
    }
}
