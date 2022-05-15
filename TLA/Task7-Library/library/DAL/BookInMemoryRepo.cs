using System;
using System.Collections.Generic;
using Library.Entities;

namespace Library.DAL
{
    public class BookInMemoryRepo : IBookRepo
    {
        private readonly List<Book> _books;
        private int _counter;

        public BookInMemoryRepo()
        {
            _books = new List<Book>();
            _counter = 0;
        }

        public Book Add(Book book)
        {
            if (book.Id.Equals(0))
            {
                book.Id = ++_counter;
                _books.Add(book);
                return book;
            }
            else
            {
                throw new Exception("Book already exists");
            }
        }
        
        public List<Book> GetAll()
        {
            return _books;
        }

        public Book Update(Book book)
        {
            for (int i = 0; i < _books.Count; i++)
            {
                Book b = _books[i];
                if (b.Id == book.Id)
                {
                    b = book;
                    return b;
                }
            }

            throw new Exception("Book not found");
        }

        public bool Delete(int id)
        {
            for (int i = 0; i < _books.Count; ++i)
            {
                if (_books[i].Id == id)
                {
                    _books.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
        
    }
}