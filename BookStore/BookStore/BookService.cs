using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    internal class BookService : IBookService
    {
        public string GetTitle(Book b) => b.Title;
        public List<string> GetAuthors(Book b) => b.Authors;
        public decimal GetPrice(Book b) => b.Price;   
    }
}
