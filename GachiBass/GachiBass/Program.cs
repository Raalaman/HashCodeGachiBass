using GachiBass.Models;
using GachiBass.Read;
using GachiBass.Write;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GachiBass
{
    class Program
    {
        private static List<string> allLines = new List<string>();
        private static List<Book> listBooks = new List<Book>();
        private static List<Library> listLibraries = new List<Library>();
        static void Main(string[] args)
        {
            allLines =Reader.ReadLines();
            string[] booksLibrariesMaxDaysDays = ReadLine();
            string[] scores = ReadLine();
           
            

            #region Obtener books y librerias
            int nummberOfBooks = Convert.ToInt32(booksLibrariesMaxDaysDays[0]);
            int nummberOfLibraries = Convert.ToInt32(booksLibrariesMaxDaysDays[1]);
            int maxDaysOfScanning = Convert.ToInt32(booksLibrariesMaxDaysDays[2]);
            for (int i = 0; i < nummberOfBooks; i++)
            {
                Book book = new Book();
                book.Id = i.ToString();
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
                library.ID = i.ToString();
                library.SignupProcesTime = signupProcessTime;
                library.NumberOfBooksCanShipt = NumberOfBooksCanShipt;
                library.NumberBooks = positionBooksInNumberOfBooks.Count();
                foreach (var positionString in positionBooksInNumberOfBooks)
                {
                    int position = Convert.ToInt32(positionString);
                    library.Books.Add(listBooks[position]);
                }
                listLibraries.Add(library);
            }
            #endregion
            listLibraries = listLibraries.OrderByDescending(x => x.NumberBooks).OrderByDescending(x => x.NumberOfBooksCanShipt).ThenBy(x => x.SignupProcesTime).ToList();
            Writer.DeleteFile();
            Writer.WriteLine(listLibraries.Count.ToString());
            foreach (var library in listLibraries)
            {
                Writer.WriteLine($"{ library.ID} { library.Books.Count}");
                string books = string.Empty;
                foreach (var book in library.Books.OrderBy(x => x.Score))
                {
                    books += $"{book.Id} ";
                }
                Writer.WriteLine(books);
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
