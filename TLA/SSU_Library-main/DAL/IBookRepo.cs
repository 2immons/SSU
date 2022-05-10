using System;
using System.Collections.Generic;
using Task7Library.Entities;

namespace Task7Library.DAL
{
    public interface IBookRepo
    {
        Book Add(Book book);

        Book Update(int id, Book book);

        List<Book> GetAll();

        Boolean Delete(int id);
    }
}
