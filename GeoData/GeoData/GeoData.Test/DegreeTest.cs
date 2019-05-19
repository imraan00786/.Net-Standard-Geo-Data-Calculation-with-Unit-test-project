using System;
using GeoData.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeoData.Test
{
    [TestClass]
    public class DegreeTest
    {
        Degree adapter = new Degree();

        [TestMethod]
        public void TestToDegrees()
        {
            double result = Math.Cos(adapter.ToDegrees(45));
            Assert.AreEqual(-0.5918127259718502, result);
            Assert.AreNotEqual(0.7, result);
        }
    }
}
