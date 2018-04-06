using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTests
{

    [TestClass]
    public class DaysTests
    {

        [TestMethod]
        public void GetDayName_MatchIntToString_ReturnCorrectDay()
        {
            Day day = new Day(75);
            //arrange
            string expected;
            string actual;
            //act
            expected = "Monday";
            actual = day.GetDayName(1);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
