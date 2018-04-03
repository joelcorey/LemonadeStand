using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int weatherLevel;

        public Weather(int weatherLevel)
        {
            this.weatherLevel = weatherLevel;
        }

        public virtual int GetWeather(int weatherLevel)
        {
            switch (weatherLevel)
            {
                case 1:
                    return weatherLevel = 10;
                case 2:
                    return weatherLevel = 20;
                case 3:
                    return weatherLevel = 30;
                case 4:
                    return weatherLevel = 40;
                case 5:
                    return weatherLevel = 50;
                case 6:
                    return weatherLevel = 60;
                case 7:
                    return weatherLevel = 70;
                case 8:
                    return weatherLevel = 80;
                case 9:
                    return weatherLevel = 90;
                case 10:
                    return weatherLevel = 100;
                default:
                    return weatherLevel = 65;
            }
        }
    }
}
