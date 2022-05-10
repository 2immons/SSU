using System;

namespace Task1_Round.Entities
{
    public class Round
    {
        public int Id { get; set; }
        public int Radius { get; set; }
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public Round(int Radius, Point center)
        {
            this.Radius = Radius > 0 ? Radius : 5;
            this.CenterX = center.X;
            this.CenterY = center.Y;
        }

        public double GetArea() => Math.PI * Radius * Radius;
        public double GetLength() => Math.PI * Math.PI * 2;

        public void Update(Round round)
        {
            this.CenterX = round.CenterX;
            this.CenterY = round.CenterY;
            this.Radius = round.Radius > 0 ? this.Radius : round.Radius;
        }

        public override String ToString()
        {
            return $"{Id}) Center ({CenterX},{CenterY}), radius = {Radius}";
        }
    }
}
