using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoData.Models;

namespace GeoData.Test
{
    /// <summary>
    /// Summary description for RadiansTest
    /// </summary>
    [TestClass]
    public class RadiansTest
    {
        Radians adapter = new Radians();

        [TestMethod]
        public void TestToDegrees()
        {
            double result = Math.Cos(adapter.ToRadians(45));
            Assert.AreEqual(0.70710678118654757, result);
            Assert.AreNotEqual(0.7, result);
        }
    }
}
