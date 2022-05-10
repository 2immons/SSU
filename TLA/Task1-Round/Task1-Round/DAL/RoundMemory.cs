using System;
using System.Collections.Generic;
using Task1_Round.Entities;

namespace Task1_Round.DAL
{
    public class RoundMemory
    {
        private static readonly List<Round> rounds;
        private static int counter;
        static RoundMemory()
        {
            rounds = new List<Round>();
            counter = 0;
        }
        public static Round Add(Round round)
        {
            if (round.Id.Equals(0))
            {
                round.Id = ++counter;
                rounds.Add(round);
                return round;
            }
            
            throw new Exception("Round already exists");
        }

        public static List<Round> GetAll() => rounds;

        public static Round Update(int id, Round round)
        {
            foreach (Round item in rounds)
                if (item.Id == id)
                {
                    item.Update(round);
                    return item;
                }

            throw new Exception("Round not found");
        }

        public static bool Delete(int id)
        {
            for (int i = 0; i < rounds.Count; ++i)
                if (rounds[i].Id == id)
                {
                    rounds.RemoveAt(i);
                    return true;
                }

            return false;
        }
    }
}
