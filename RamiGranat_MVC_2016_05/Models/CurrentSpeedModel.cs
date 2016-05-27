using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RamiGranat_MVC_2016_05.Models
{
    public class CurrentSpeedModel
    {
        public string GetCurrentSpeed(double distanceCovered, double time)
        {
            if(distanceCovered < 0 || time < 0)
            {
                return "Distance covered and time cannot be negative numbers!";
            }
            double speed = distanceCovered / time;
            return speed.ToString();
        }
    }
        [TestFixture]
    public class CorrectCalculationTest
    {
        [Test]
        public void CorrectCalculation()
        {
            CurrentSpeedModel currentSpeed = new CurrentSpeedModel();
            var actual = currentSpeed.GetCurrentSpeed(2, 2);
            var expected = "1";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    [TestFixture]
    public class UseDecimalNumbersTest
    {
        [Test]
        public void UseDecimalNumbers()
        {
            CurrentSpeedModel currentSpeed = new CurrentSpeedModel();
            var actual = currentSpeed.GetCurrentSpeed(0.4, 2);
            var expected = "0.2";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
    [TestFixture]
    public class TimeCannotBeNegativeTest
    {
        [Test]
        public void NoNegativeNumbers()
        {
            CurrentSpeedModel currentSpeed = new CurrentSpeedModel();
            var actual = currentSpeed.GetCurrentSpeed(1, -1);
            var expected = "Distance covered and time cannot be negative numbers!";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}