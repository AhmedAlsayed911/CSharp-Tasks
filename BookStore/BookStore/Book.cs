using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string isbn , string title , List<string> authors , DateTime publicationDate , decimal price)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }


        public override string ToString()
        {         
            return $"ISBN : {ISBN} : \n" +
                $"Title : {Title}\n" +
                $"PublicationDate : {PublicationDate}\n" +
                $"{string.Join(" , ",Authors)}" +
                $"{Price}\n";
        }
    }
}
