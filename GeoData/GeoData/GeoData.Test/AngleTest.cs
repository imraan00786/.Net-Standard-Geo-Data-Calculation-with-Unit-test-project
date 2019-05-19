using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoData;
using GeoData.Models;

namespace GeoData.Test
{
    [TestClass]
    public class AngleTest
    {
        AngleAbstract adapter = new AngleModel();

        [TestMethod]
        public void AddOperatorTest()
        {
            Angle angle1 = new Angle(0.70710678118654757, Angle.Type.Radians);
            Angle angle2 = new Angle(0.10710678118654757, Angle.Type.Radians);
            Angle angle3 = angle1 + angle2;

            Assert.AreEqual("0.814213562373095 radians", angle3);
            Assert.AreNotEqual(0.7, angle3);
        }

        [TestMethod]
        public void SubtractOperatorTest()
        {
            Angle angle1 = new Angle(0.70710678118654757, Angle.Type.Radians);
            Angle angle2 = new Angle(0.10710678118654757, Angle.Type.Radians);
            Angle angle3 = angle1 - angle2;

            Assert.AreEqual("0.6 radians", angle3);
            Assert.AreNotEqual(0.7, angle3);
        }

        [TestMethod]
        public void MultiplyOperatorTest()
        {
            Angle angle1 = new Angle(0.70710678118654757, Angle.Type.Radians);
            Angle angle2 = angle1 * 0.10710678118654757;

            Assert.AreEqual("0.0757359312880715 radians", angle2);
            Assert.AreNotEqual(0.7, angle2);
        }

        [TestMethod]
        public void TestRadianToDegrees()
        {
            double angle = Math.Cos(adapter.RadianToDegree(45));
            Assert.AreEqual(-0.5918127259718502, angle);
            Assert.AreNotEqual(0.7, angle);
        }


    }
}
