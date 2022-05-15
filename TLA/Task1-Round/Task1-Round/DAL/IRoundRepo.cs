using System.Collections.Generic;
using Task1_Round.Entities;

namespace Task1_Round.DAL
{
    public interface IRoundRepo
    {
        Round Add(Round book);

        Round Update(int id, Round book);

        List<Round> GetAll();

        bool Delete(int id);
    }
}
