using System;
using System.Collections.Generic;
using System.Text;

namespace GachiBass.Models
{
    public class Library
    {
        public string ID { get; set; }
        public List<Book> Books { get; set; }
        public int Time { get; set; }
        public int MaxScanned { get; set; }
        public bool SignedUp { get; set; }
        public int SignupProcesTime { get; set; }
        public int NumberOfBooksCanShipt { get; set; }
        public int NumberBooks { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
    }
}
