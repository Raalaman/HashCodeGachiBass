using GachiBass.Models;
using System;
using System.Collections.Generic;

namespace GachiBass
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummberOfBooks = 0;
            int nummberOfLibraries = 0;
            int nummberOfScanningDays = 0;

            List<Book> listBooks = new List<Book>();
            List<Library> listLibraries = new List<Library>();
            List<ScanningDays> listScanningDays = new List<ScanningDays>();
            for (int i = 0; i < nummberOfBooks - 1; i++)
            {
                Book book = new Book();
                listBooks.Add(book);
            }
            for (int i = 0; i < nummberOfLibraries - 1; i++)
            {
                Library library = new Library();
                listLibraries.Add(library);
            }
            for (int i = 0; i < nummberOfScanningDays - 1; i++)
            {
                ScanningDays day= new ScanningDays();
                listScanningDays.Add(day);
            }

        }
    }
}
