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
        /// <summary>
        /// Public list of times for the day
        /// </summary>
        public List<Tuple<DateTime, DateTime>> timeBoxForDay;

        /// <summary>
        /// Public date
        /// </summary>
        public DateTime date;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedDate">Date</param>
        /// <param name="times">List of times for the day</param>
        public Day(DateTime selectedDate, List<Tuple<DateTime, DateTime>> times)
        {
            date = selectedDate;
            timeBoxForDay = times;
        }
    }
}