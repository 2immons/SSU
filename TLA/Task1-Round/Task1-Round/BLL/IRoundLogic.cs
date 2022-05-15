using System.Collections.Generic;
using Task1_Round.Entities;

namespace Task1_Round.BLL
{
    public interface IRoundLogic
    {
        Round Create(Point PointCenter, int radius);

        List<Round> FindAll();

        Round Update(int id, Point PointCenter, int radius);

        bool Delete(int id);

        Round Find(int id);
    }
}
