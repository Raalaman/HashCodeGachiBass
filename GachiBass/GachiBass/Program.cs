using GachiBass.Models;
using GachiBass.Read;
using System;
using System.Collections.Generic;

namespace GachiBass
{
    class Program
    {
        private static List<string> allLines = new List<string>();
        static void Main(string[] args)
        {
            allLines =Reader.ReadLines();
            string[] booksLibrariesMaxDaysDays = ReadLine();
            string[] scores = ReadLine();

            List<Book> listBooks = new List<Book>();
            List<Library> listLibraries = new List<Library>();

            int nummberOfBooks = Convert.ToInt32(booksLibrariesMaxDaysDays[0]);
            int nummberOfLibraries = Convert.ToInt32(booksLibrariesMaxDaysDays[1]);
            int maxDaysOfScanning = Convert.ToInt32(booksLibrariesMaxDaysDays[2]);
            for (int i = 0; i < nummberOfBooks; i++)
            {
                Book book = new Book();
                book.Score = Convert.ToInt32(scores[i]);
                listBooks.Add(book);
            }                       
            
            for (int i = 0; i < nummberOfLibraries; i++)
            {

                string[] booksSignupProcessTimeNumberCanShip = ReadLine();
                string[] positionBooksInNumberOfBooks = ReadLine();

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
        public static string [] ReadLine()
        {
            var firstLine = allLines[0];
            allLines.RemoveAt(0);
            return firstLine.Split(" ");
        }
    }
}
