using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class Configuration
    {
        public static List<string> wundergroundCities = new List<string>(new string[] {
            "/ak/anchorage.json",
            "/il/chicago.json",
            "/hi/honolulu.json",
            "/ca/losangeles.json",
            "/fl/miami.json",
            "/wi/milwaukee.json",
            "/or/moro.json",
            "/or/portland.json",
            "/wa/seattle.json",
            "/wa/spokane.json"
        });

        public static string databaseConnect = @"Data Source=C:\install\project\devcode\visualStudio2015\projects\LemonadeStand\lemonadestand.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

    }
}
