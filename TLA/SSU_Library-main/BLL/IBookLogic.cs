using System;
using System.Collections.Generic;
using Task7Library.Entities;

namespace Task7Library.BLL
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
