using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GachiBass.Write
{
    class Writer
    {
        public static void WriteLine(string line)
        {
            using StreamWriter sr = new StreamWriter("TestFile.txt");
            sr.WriteLine(line);
            sr.Flush();
        }
    }
}
