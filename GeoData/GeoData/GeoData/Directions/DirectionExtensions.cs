using System;
using System.Collections.Generic;
using System.Text;

namespace GeoData.Directions
{
    public static class DirectionExtensions
    {
        private static readonly Dictionary<Enum.Direction, string>
            mapping = new Dictionary<Enum.Direction, string>
        {
        { Enum.Direction.North, "n" },
        { Enum.Direction.NorthEast, "ne" },
        { Enum.Direction.East, "e" },
        { Enum.Direction.SouthEast, "se" },
        { Enum.Direction.South, "s" },
        { Enum.Direction.SouthWest, "sw" },
        { Enum.Direction.West, "w" },
        { Enum.Direction.NorthWest, "nw" }
        };

        public static bool IncludesHeading(this Enum.Direction direction, int heading)
        {
            var adjusted = (heading + 22) % 360;
            var adjMin = (int)direction * 45;
            var adjMax = adjMin + 44;
            return (adjusted >= adjMin && adjusted <= adjMax);
        }

        public static string GetSuffix(this Enum.Direction direction)
        {
            return mapping[direction];
        }
    }
}
