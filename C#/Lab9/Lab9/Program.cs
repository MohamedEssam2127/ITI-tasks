namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("978-0553103540", "A Game of Thrones", new string[] { "George Martin" }, new DateTime(1996, 8, 6), 550m),
                new Book("978-0553108033", "A Clash of Kings", new string[] { "George  Martin" ,"Essam" }, new DateTime(1998, 11, 16), 600m),
                new Book("978-0553106633", "A Storm of Swords", new string[] { "George Martin" }, new DateTime(2000, 8, 8), 650m)
            };

            Console.WriteLine(" User defined delegate ");
            BookPtr pricePtr = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, pricePtr);

            Console.WriteLine("\n BCL delegate ");
            Func<Book, string> ptr2 = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, new BookPtr(ptr2));

            Console.WriteLine("\n Anonymous method (GetISBN)");
            LibraryEngine.ProcessBooks(books, delegate (Book B) { return B.ISBN; });

            Console.WriteLine("\n Lambda expression (GetPublicationDate) ");
            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToShortDateString());
        }
    }
}
