using System;
using System.Collections.Generic;
using System.Text;

namespace GeoData.Logger
{
    public class FileLogger
    {
        public void Log(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
