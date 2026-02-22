namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("978-0-123456-47-2", "C# Programming",
                    new List<string>() { "John Doe", "Jane Smith" },
                    new DateTime(2020, 05, 15), 49.99m),
                new Book("978-0-987654-32-1", "Advanced .NET",
                    new List<string>() { "Alice Johnson" },
                    new DateTime(2021, 08, 20), 59.99m),
                new Book("978-0-555555-55-5", "Design Patterns",
                    new List<string>() { "Bob Wilson", "Charlie Brown" },
                    new DateTime(2019, 03, 10), 39.99m)
            };

            var book = new Book("978-0-123456-47-2", "C# Programming",
                    new List<string>() { "John Doe", "Jane Smith" },
                    new DateTime(2020, 05, 15), 49.99m);

            IBookService bookService = BookServiceFactory.Create();
            LibraryEngine.ProcessBooks(books, x => x.Price == 59.99m);


            LibraryEngine.GetAuthorsDelegate del = bookService.GetAuthors;
            var auths = del(book);
            foreach (var auth in auths) 
                Console.WriteLine(auth);

        }
    }
}
