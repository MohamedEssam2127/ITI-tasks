using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    public delegate string BookPtr(Book B);

    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title,
            string[] _Authors, DateTime _PublicationDate,decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;

        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}\n" +
                   $"Title: {Title}\n" +
                   $"Authors: {string.Join(", ", Authors)}\n" +
                   $"Publication Date: {PublicationDate.ToShortDateString()}\n" +
                   $"Price: {Price}";
        }
    }

    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return $"Authors: {string.Join(", ", B.Authors)}\n";
        }

        public static string GetPrice(Book B)
        {
            return $"Price: {B.Price}";
        }
    }
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookPtr fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
