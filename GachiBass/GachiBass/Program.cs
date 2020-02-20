using GachiBass.Models;
using GachiBass.Read;
using System;
using System.Collections.Generic;

namespace GachiBass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] booksLibrariesMaxDaysDays = Reader.ReadLine();
            string[] scores = Reader.ReadLine();

            List<Book> listBooks = new List<Book>();
            List<Library> listLibraries = new List<Library>();

            int nummberOfBooks = 0;
            int nummberOfLibraries = 0;
            int maxDaysOfScanning = 0;
            for (int i = 0; i < nummberOfBooks - 1; i++)
            {
                Book book = new Book();
                book.Score = Convert.ToInt32(scores[i]);
                listBooks.Add(book);
            }                       
            
            for (int i = 0; i < nummberOfLibraries - 1; i++)
            {

                string[] booksSignupProcessTimeNumberCanShip = Reader.ReadLine();
                string[] positionBooksInNumberOfBooks = Reader.ReadLine();

                int signupProcessTime = Convert.ToInt32(booksSignupProcessTimeNumberCanShip[1]);
                int NumberOfBooksCanShipt = Convert.ToInt32(booksSignupProcessTimeNumberCanShip[2]);

                Library library = new Library();
                library.SignupProcesTime = signupProcessTime;
                library.NumberOfBooksCanShipt = NumberOfBooksCanShipt;
                foreach (var positionString in positionBooksInNumberOfBooks)
                {
                    int position = Convert.ToInt32(positionString);
                    library.Books.Add(listBooks[position]);
                }
                listLibraries.Add(library);
            }
        }
    }
}
