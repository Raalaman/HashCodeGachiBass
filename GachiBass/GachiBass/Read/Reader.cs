using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GachiBass.Read
{
    public class Reader
    {

        public static List<string> ReadLines(string file)
        {
            using (StreamReader sr = new StreamReader(file, Encoding.Default))
            {
                return ReadLines(sr, '\n').ToList();
            }

        }
        public static IEnumerable<string> ReadLines(TextReader reader, char delimiter)
        {
            List<char> chars = new List<char>();
            while (reader.Peek() >= 0)
            {
                char c = (char)reader.Read();

                if (c == delimiter)
                {
                    yield return new String(chars.ToArray());
                    chars.Clear();
                    continue;
                }

                chars.Add(c);
            }
        }
    }
}
