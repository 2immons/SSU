using System.Collections.Generic;
using Library.DAL;
using Library.Entities;

namespace Library.BLL
{
    public class BookLogicImpl : IBookLogic
    {
        private readonly IBookRepo _bookRepo;

        public BookLogicImpl(IBookRepo bookRepo)
        {
            this._bookRepo = bookRepo;
        }

        public Book Create(string name, int pageCount)
        {
            Book book = new Book();
            book.Name = name;
            book.PageCount = pageCount;
            return _bookRepo.Add(book);
        }

        public List<Book> FindAll()
        {
            return _bookRepo.GetAll();
        }

        public Book Update(int id, string name, int pageCount)
        {
            Book bookTemplate = new Book();
            bookTemplate.Id = id;
            bookTemplate.Name = name;
            bookTemplate.PageCount = pageCount;
            return _bookRepo.Update(bookTemplate);
        }

        public bool Delete(int id)
        {
            return _bookRepo.Delete(id);
        }

        public Book Find(int id)
        {
            List<Book> books = _bookRepo.GetAll();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    return b;
                }
            }

            return null;
        }
    }
}