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
            using StreamWriter sr = new StreamWriter("OutPut.txt", true);
            sr.WriteLine(line);
            sr.Flush();
        }

        internal static void DeleteFile()
        {
            File.Delete("OutPut.txt");
        }
    }
}
