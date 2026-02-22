using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    internal interface IBookService
    {
        public string GetTitle(Book b);
        public List<string> GetAuthors(Book b);
        public decimal GetPrice(Book b);
    }
}
