using System;
using System.Collections.Generic;
using System.Text;

namespace GeoData.Models
{
    public abstract class AngleAbstract
    {
        public double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }
    }
}
