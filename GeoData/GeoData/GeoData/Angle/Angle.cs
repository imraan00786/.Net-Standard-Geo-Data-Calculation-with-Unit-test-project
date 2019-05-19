using System;
using System.Collections.Generic;
using System.Text;

namespace GeoData
{
    /// <summary>
    /// Holds an angle as both radians and degrees, with conversions between each
    /// </summary>
    public class Angle
    {
        #region constructors
        /// <summary>
        /// Blank constructor. Remember to manually set some data to the properties!
        /// </summary>
        public Angle()
        {

        }
        /// <summary>
        /// Construct an angle with either a degree or a radian value
        /// </summary>
        /// <param name="input">Angle value</param>
        /// <param name="angleType">Specify whether input is in radians or degrees</param>
        public Angle(double input, Type angleType = Angle.Type.Radians)
        {
            if (angleType == Type.Degrees)
            {
                Degrees = input;
            }
            else if (angleType == Type.Radians)
            {
                Radians = input;
            }
        }
       
        #endregion constructors


        #region properties
        private double degrees;

        /// <summary>
        /// Angle in degrees
        /// </summary>
        public double Degrees
        {
            get { return degrees; }
            set
            {
                degrees = value;
                radians = ToRadians(value);
            }
        }

        private double radians;
        /// <summary>
        /// Angle in radians between -pi to pi
        /// </summary>
        public double Radians
        {
            get { return radians; }
            set
            {
                radians = value;
                degrees = ToDegrees(value);
            }
        }

        #endregion properties


        #region enums
        public enum Type { Radians, Degrees }
        /// <summary>
        /// Presets for quick setup of Angle constructor
        /// </summary>
        public enum Preset { Deg0, Deg180, Deg360, RadPi, Rad2Pi }
        #endregion enums


        #region constants
        private const double Pi = Math.PI;
        #endregion constants


        #region methods
        /// <summary>
        /// Convert an input angle of degrees to radians. Does not affect any properties in this class - set properties instead.
        /// </summary>
        /// <param name="val">Input in degrees</param>
        /// <returns>Value in radians</returns>
        public static double ToRadians(double val)
        {
            return val / (180 / Pi);
        }

        /// <summary>
        /// Convert an input angle of radians into degrees. Does not affect any properties in this class - set properties instead.
        /// </summary>
        /// <param name="val">Input in radians</param>
        /// <returns>Value in degrees</returns>
        public static double ToDegrees(double val)
        {
            return val * (180 / Pi);
        }
        #endregion methods


        #region operators

        /// <summary>
        /// Returns the sum of two angles
        /// </summary>
        /// <param name="a1">First angle</param>
        /// <param name="a2">Second angle</param>
        /// <returns>An angle constructed from the radian sum of the input angles</returns>
        public static Angle operator +(Angle a1, Angle a2)
        {
            return new Angle(a1.Radians + a2.Radians, Type.Radians);
        }

        /// <summary>
        /// Returns the difference between two angles
        /// </summary>
        /// <param name="a1">First angle</param>
        /// <param name="a2">Second angle</param>
        /// <returns>An angle constructed from the value that is the first angle minus the second angle</returns>
        public static Angle operator -(Angle a1, Angle a2)
        {
            return new Angle(a1.Radians - a2.Radians, Type.Radians);
        }

        /// <summary>
        /// Returns the exact division between two angles (i.e. how many times does the second angle fit into the first)
        /// </summary>
        /// <param name="a1">Numerator angle</param>
        /// <param name="a2">Dedominator angle</param>
        /// <returns>A new angle constructed from the value that is the first angle in radians divided by the second angle in radians</returns>
        public static Angle operator /(Angle a1, Angle a2)
        {
            return new Angle(a1.Radians / a2.Radians, Type.Radians);
        }

        public static Angle operator *(Angle a, double d)
        {
            return new Angle(a.Radians * d, Type.Radians);
        }

        public static Angle operator *(double d, Angle a)
        {
            return new Angle(a.Radians * d, Type.Radians);
        }

        public static Angle operator /(Angle a, double d)
        {
            return new Angle(a.Radians / d, Type.Radians);
        }

        public static bool operator <(Angle a1, Angle a2)
        {
            if (a1.Radians < a2.Radians) return true;
            else return false;
        }

        public static bool operator >(Angle a1, Angle a2)
        {
            if (a1.Radians > a2.Radians) return true;
            else return false;
        }

        public static bool operator <=(Angle a1, Angle a2)
        {
            if (a1.Radians <= a2.Radians) return true;
            else return false;
        }

        public static bool operator >=(Angle a1, Angle a2)
        {
            if (a1.Radians >= a2.Radians) return true;
            else return false;
        }

        public static bool operator ==(Angle a1, Angle a2)
        {
            if (a1.Radians == a2.Radians) return true;
            else return false;
        }

        public static bool operator !=(Angle a1, Angle a2)
        {
            if (a1.Radians != a2.Radians) return true;
            else return false;
        }

        public static implicit operator string(Angle a)
        {
            return a.ToString();
        }
        #endregion operators


        #region overrides
        public override string ToString()
        {
            return Radians.ToString() + " radians";
        }
        #endregion overrides

    }
}
