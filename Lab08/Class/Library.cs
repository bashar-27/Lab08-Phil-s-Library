using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.Class
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> ReserveABook = new Dictionary<string, Book>();
        public int Count => ReserveABook.Count();


        public Library()
        {
            ReserveABook = new Dictionary<string, Book>();
        }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            var book = new Book
            {
                Title = title,
                Author = firstName + " " + lastName,
                Page = numberOfPages,
            };
            ReserveABook.Add(title, book);
        }


        public Book Borrow(string title)
        {
            if (ReserveABook.ContainsKey(title))
            {
                Book bookBorrow = ReserveABook[title];
                ReserveABook.Remove(title);
                return bookBorrow;
            }
            return null;
        }

        public void Return(Book book)
        {
            ReserveABook?.Add(book.Title, book);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var item in ReserveABook.Values)
            {
                yield return item;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in ReserveABook.Values)
            {
                yield return item;

            }
        }
    }
}
