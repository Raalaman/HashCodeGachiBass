using System;
using System.Collections.Generic;
using System.Text;

namespace GachiBass.Models
{
    public class Libarary
    {
        public string ID { get; set; }
        public List<Book> Books { get; set; }
        public int Time { get; set; }
        public int MaxScanned { get; set; }
        public bool SignedUp { get; set; }
    }
}
