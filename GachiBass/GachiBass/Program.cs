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
            List<int> scores = new List<int>();
            
            List<Book> listBooks = new List<Book>();
            List<Library> listLibraries = new List<Library>();
            List<ScanningDays> listScanningDays = new List<ScanningDays>();
            for (int i = 0; i < nummberOfBooks - 1; i++)
            {
                Book book = new Book();
                book.Score = scores[i];
                listBooks.Add(book);
            }
            int signupProcessTime = 0;
            int NumberOfBooksCanShipt = 0;
            List<int> positionBooksInNumberOfBooks = new List<int>();
            for (int i = 0; i < nummberOfLibraries - 1; i++)
            {
                Library library = new Library();
                library.SignupProcesTime = signupProcessTime;
                library.NumberOfBooksCanShipt = NumberOfBooksCanShipt;
                foreach(var position in positionBooksInNumberOfBooks)
                {
                    library.Books.Add(listBooks[position]);
                }
                listLibraries.Add(library);
            }
        }
    }
}
