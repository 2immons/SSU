using System;
using System.Collections.Generic;
using Task1_Round.DAL;
using Task1_Round.Entities;

namespace Task1_Round.BLL
{
    public class RoundLogicImpl
    {
        public static Round Create(int radius, int x, int y)
        {
            Point center = new Point(x, y);
            Round round = new Round(radius, center);
            return RoundMemory.Add(round);
        }

        public static List<Round> FindAll() => RoundMemory.GetAll();

        public static Round Update(int id, int radius, int x, int y)
        {
            Point center = new Point(x, y);
            Round newRound = new Round(radius, center);
            return RoundMemory.Update(id, newRound);
        }

        public static bool Delete(int id) => RoundMemory.Delete(id);

        public static Round Find(int id)
        {
            List<Round> books = RoundMemory.GetAll();
            foreach (Round b in books)
                if (b.Id == id)
                    return b;

            return null;
        }

    }
    
}
