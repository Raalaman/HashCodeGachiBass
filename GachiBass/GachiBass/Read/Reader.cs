using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GachiBass.Read
{
    public class Reader
    {

        public static string [] ReadLine()
        {
            using StreamReader sr = new StreamReader("texto.txt");
            string linea = sr.ReadToEnd();

            return linea.Split(" ");
        }
    }
}
