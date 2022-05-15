using System;
using System.Text.Json.Serialization;

namespace Task1_Round.Entities
{
    public class Round
    {
        public int Id { get; set; }
        public Point Center { get; set; }
        public int Radius { get; set; }

        [JsonConstructorAttribute]
        public Round(int id, Point center, int radius)
        {
            Id = id;
            Center = center;
            Radius = radius;
        }

        public Round(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }

        public double GetArea() => Math.PI * Radius * 2;
        public double GetSquare() => Math.PI * Radius * Radius;

        public void Update(Round round)
        {
            this.Center = round.Center ?? this.Center;
            this.Radius = round.Radius; 
        }

        public override String ToString()
        {
            return $"{Id}) Center ({Center.X},{Center.Y}), radius = {Radius}, area = {this.GetArea()}, length = {this.GetArea()}";
        }

    }
}
