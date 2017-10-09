using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Day
    {
        public List<Tuple<DateTime, DateTime>> timeBoxForDay;
        public DateTime date;

        public Day(DateTime selectedDate, List<Tuple<DateTime, DateTime>> times)
        {
            date = selectedDate;
            timeBoxForDay = times;
            /*DateTime i1;
            DateTime i2 = new DateTime(D);

            //
            // Find a way to change the date or we are all fucked
            //


            foreach (Tuple<DateTime,DateTime> timeSet in times)
            {
                i1 = timeSet.Item1;
                i2 = timeSet.Item2;

                i1.Date = date.Date;
                i2.Date = date.Date;


            }*/
        }
    }
}