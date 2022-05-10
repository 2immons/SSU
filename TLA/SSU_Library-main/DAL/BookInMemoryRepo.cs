using System;
using System.Collections.Generic;
using Task7Library.Entities;

namespace Task7Library.DAL
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

        public Book Update(int id, Book book)
        {
            foreach (Book b in _books)
            {
                if (b.Id == id)
                {
                    b.Update(book);
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