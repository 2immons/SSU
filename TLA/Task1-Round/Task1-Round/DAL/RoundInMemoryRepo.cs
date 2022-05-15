using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Task1_Round.Entities;

namespace Task1_Round.DAL
{
    public class RoundInMemoryRepo : IRoundRepo
    {
        private readonly List<Round> rounds;
        private int counter;
        private string path = @"D:\GitHub\SSU\TLA\Task1-Round\Task1-Round\memory.txt";

        public RoundInMemoryRepo()
        {
            string json = File.ReadAllText(path);
            if (json != "")
                rounds = JsonSerializer.Deserialize<List<Round>>(json) ?? new List<Round>();
            else
                rounds = new List<Round>();

            counter = rounds.Count;
        }

        public Round Add(Round round)
        {
            if (round.Id.Equals(0))
            {
                round.Id = ++counter;
                rounds.Add(round);
            }
            else
                throw new Exception("Round already exists");

            string jsonString = JsonSerializer.Serialize(rounds);
            File.WriteAllText(path, jsonString);

            return round;
        }

        public bool Delete(int id)
        {
            for (int i = 0; i < rounds.Count; ++i)
                if (rounds[i].Id == id)
                {
                    rounds.RemoveAt(i);

                    string jsonString = JsonSerializer.Serialize(rounds);
                    File.WriteAllText(path, jsonString);

                    return true;
                }

            return false;
        }

        public List<Round> GetAll() => rounds;

        public Round Update(int id, Round round)
        {
            foreach (Round roundItem in rounds)
                if (roundItem.Id == id)
                {
                    roundItem.Update(round);

                    string jsonString = JsonSerializer.Serialize(rounds);
                    File.WriteAllText(path, jsonString);

                    return roundItem;
                }
            throw new Exception("Round not found");
        }
    }
}
