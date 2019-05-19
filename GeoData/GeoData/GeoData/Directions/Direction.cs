using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GeoData.Directions
{
    /// <summary>
    /// Direction
    /// </summary>
    public class Direction
    {
        /// <summary>
        /// Direction
        /// </summary>
        public Direction()
        {

        }

        /// <summary>
        /// GetDirection
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        static Enum.Direction GetDirection(Point p1, Point p2)
        {
            double rad = Math.Atan2(p2.Y - p1.Y, p2.X - p1.X);

            // Ajust result to be between 0 to 2*Pi
            if (rad < 0)
                rad = rad + (2 * Math.PI);

            var deg = rad * (180 / Math.PI);

            if (deg == 0)
                return Enum.Direction.East;
            else if (deg == 45)
                return Enum.Direction.NorthEast;
            else if (deg == 90)
                return Enum.Direction.North;
            else if (deg == 135)
                return Enum.Direction.NorthWest;
            else if (deg == 180)
                return Enum.Direction.West;
            else if (deg == 225)
                return Enum.Direction.SouthWest;
            else if (deg == 270)
                return Enum.Direction.South;
            else if (deg == 315)
                return Enum.Direction.SouthEast;
            else
                return Enum.Direction.Undefined;
        }

        /// <summary>
        /// GetCompasDirection
        /// </summary>
        /// <param name="heading"></param>
        /// <returns></returns>
        public Enum.Direction GetCompasDirection(int heading)
        {
            // directions in clock-wise order:
            var directionUpperLimitAngles = new[] {
                     Tuple.Create(Enum.Direction.North, 22),
                     Tuple.Create(Enum.Direction.NorthEast, 67),
                     Tuple.Create(Enum.Direction.East, 112),
                     // other directions,
                     Tuple.Create(Enum.Direction.North, 360), // north again
                };

            return directionUpperLimitAngles.Last(d => d.Item2 <= heading).Item1;
        }

        public Enum.Direction GetMathmaticalDirection(int heading)
        {
            // directions in clock-wise order:
            var directionUpperLimitAngles = new[] {
                     Tuple.Create(Enum.Direction.North, 22),
                     Tuple.Create(Enum.Direction.NorthEast, 67),
                     Tuple.Create(Enum.Direction.East, 112),
                     // other directions,
                     Tuple.Create(Enum.Direction.North, 360), // north again
                };

            return directionUpperLimitAngles.Last(d => d.Item2 <= heading).Item1;
        }
    }
}
