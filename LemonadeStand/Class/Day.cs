using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        // Member variables
        // Customers per hour?
        public string dayName;
        public int dayTemperature;

        // Constructor
        public Day(int temperature)
        {
            this.dayTemperature = temperature;
        }

        // Member methods

        public string GetDayName(int dayTracker)
        {
            if (dayTracker == 1)
            {
                dayName = "Monday";
            }
            else if (dayTracker == 2)
            {
                dayName = "Tuesday";
            }
            else if (dayTracker == 3)
            {
                dayName = "Wednesday";
            }
            else if (dayTracker == 4)
            {
                dayName = "Thursday";
            }
            else if (dayTracker == 5)
            {
                dayName = "Friday";
            }
            else if (dayTracker == 6)
            {
                dayName = "Saturday";
            }
            else if (dayTracker == 7)
            {
                dayName = "Sunday";
            }
            else
            {
                dayName = "Invalid dayTracker / dayName";
            }
            return dayName;
        }



    }
}
