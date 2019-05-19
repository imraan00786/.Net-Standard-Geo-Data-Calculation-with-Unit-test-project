using GeoData;
using GeoData.Models;
using System;

namespace GeoDataConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double angle = Math.Cos(Angle.ToRadians(45));
            var an1 = new Angle(4.4, Angle.Type.Degrees);
            var an2 = new Angle(5.4, Angle.Type.Degrees);
            var angleadd = new Angle();

            AngleAbstract adapter = new AngleModel();
            double angle1 = Math.Cos(adapter.DegreeToRadian(45));
            Console.WriteLine(angle);
            Console.WriteLine(angle1);
            Console.ReadLine();
        }
    }
}
