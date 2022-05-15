using System;
using System.Collections.Generic;
using Library.Entities;

namespace Library.BLL
{
    public interface IBookLogic
    {
        Book Create(string name, int pageCount);
        
        List<Book> FindAll();

        Book Update(int id, string name, int pageCount);
        
        Boolean Delete(int id);
        
        Book Find(int id);
    }
}
