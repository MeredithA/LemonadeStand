using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTests
{
    [TestClass]
    public class WeatherTests
    {
        [TestMethod]
        public void Weather_WithinRangeIndex_SetsCondition()
        {
            Weather weather = new LemonadeStand.Weather();
            //arrange
            string expected = "sunny";
            string actual;

            //act
            
            actual = weather.weatherConditionPossibilities[0];

            //assert

            Assert.AreEqual(actual, expected);


        }
    }
}
