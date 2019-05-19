using GeoData.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeoData.Models
{
    public abstract class BaseModel
    {

        #region methods
        /// <summary>
        /// Convert an input angle of degrees to radians. Does not affect any properties in this class - set properties instead.
        /// </summary>
        /// <param name="val">Input in degrees</param>
        /// <returns>Value in radians</returns>
        public double ToRadians(double val)
        {
            return val / (180 / Constant.Pi);
        }

        /// <summary>
        /// Convert an input angle of radians into degrees. Does not affect any properties in this class - set properties instead.
        /// </summary>
        /// <param name="val">Input in radians</param>
        /// <returns>Value in degrees</returns>
        public double ToDegrees(double val)
        {
            return val * (180 / Constant.Pi);
        }

        #endregion methods
    }
}
