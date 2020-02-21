using GachiBass.Models;
using GachiBass.Read;
using GachiBass.Write;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GachiBass
{
    class Program
    {
        private static List<string> allLines = new List<string>();
        private static List<Book> listBooks = new List<Book>();
        private static List<Library> listLibraries = new List<Library>();
        static void Main(string[] args)
        {
            var files = new List<string>();
            
            files.Add("c_incunabula.txt");
            files.Add("b_read_on.txt");
            files.Add("d_tough_choices.txt");
            files.Add("e_so_many_books.txt");
            files.Add("f_libraries_of_the_world.txt");

            foreach (var file in files)
            {
                allLines = Reader.ReadLines(file);
                string[] booksLibrariesMaxDaysDays = ReadLine();
                string[] scores = ReadLine();


                listBooks.Clear();
                listLibraries.Clear();
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
                listLibraries = listLibraries.OrderBy(x => x.SignupProcesTime).ThenByDescending(x => x.NumberBooks).ThenByDescending(x => x.NumberOfBooksCanShipt).ToList();
                Writer.DeleteFile($"{file}_OutPut.txt");
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(listLibraries.Count.ToString());
                int count = 0;
                foreach (var library in listLibraries)
                {

                    stringBuilder.AppendLine($"{ library.ID} { library.Books.Count}");
                    string books = string.Empty;
                    foreach (var book in library.Books.OrderByDescending(x => x.Score))
                    {
                        books += $"{book.Id} ";
                    }
                    stringBuilder.AppendLine(books);
                    if (count == 200)
                    {
                        File.AppendAllText($"{file}_OutPut.txt", stringBuilder.ToString());
                        stringBuilder.Clear();
                        count = 0;
                    }
                    count++;
                }
                File.AppendAllText($"{file}_OutPut.txt", stringBuilder.ToString());
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
