using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{

    public class LibraryEngine
    {
        // public List<string> GetAuthors(Book b) => b.Authors;
        public delegate List<T> Authors<T>(Book b);
        public delegate bool BookDel<T>(Book b);
        public delegate List<string> GetAuthorsDelegate(Book b);
        public static void ProcessBooks(List<Book> books, BookDel<Book> predicate)
        {
            foreach (var book in books)
            {
                if (predicate(book))
                    Console.WriteLine(book);
            }
        }
        
    }
}
