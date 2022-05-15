using System;
using System.Collections.Generic;
using Library.Entities;

namespace Library.DAL
{
    public interface IBookRepo
    {
        Book Add(Book book);

        Book Update(Book book);

        List<Book> GetAll();

        Boolean Delete(int id);

    }
}
