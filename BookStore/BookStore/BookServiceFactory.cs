using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore
{
    internal class BookServiceFactory
    {
        public static IBookService Create()
        {
            return new BookService();
        }
    }
}
