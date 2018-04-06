using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTests
{
    [TestClass]
    public class WeatherTests
    {
        [TestMethod]
        public void GetTemperatureFallback_CorellateRandomToInt_ReturnsCorallatedNumber()
        {
            Weather weather = new Weather();
            //Arrange
            int expected = 10;
            int actual;
            //Act
            actual = weather.GetTemperatureFallback(1);
            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GetTemperatureFallback_CorellateRandomToInt_ReturnsDefaultValue()
        {
            Weather weather = new Weather();
            //Arrange
            int expected = 75;
            int actual;
            //Act
            actual = weather.GetTemperatureFallback(0);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
