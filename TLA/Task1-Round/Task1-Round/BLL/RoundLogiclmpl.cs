using System;
using System.Collections.Generic;
using Task1_Round.DAL;
using Task1_Round.Entities;

namespace Task1_Round.BLL
{
    public class RoundLogiclmpl : IRoundLogic
    {
        private readonly IRoundRepo roundRepo;

        public RoundLogiclmpl(IRoundRepo roundRepo)
        {
            this.roundRepo = roundRepo;
        }

        public Round Create(Point center, int radius)
        {
            if (radius <= 0)
                throw new Exception("Radius <= 0");
            Round round = new Round(center, radius);
            return roundRepo.Add(round);
        }

        public bool Delete(int id) => roundRepo.Delete(id);

        public Round Find(int id)
        {
            List<Round> rounds = roundRepo.GetAll();
            foreach (Round roundItem in rounds)
            if (roundItem.Id == id)
                return roundItem;
            return null;
        }

        public List<Round> FindAll() => roundRepo.GetAll();

        public Round Update(int id, Point center, int radius)
        {
            Round round = new Round(center, radius);
            return roundRepo.Update(id, round);
        }
    }
}
