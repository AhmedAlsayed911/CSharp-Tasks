using System;
using System.Collections.Generic;
using System.Text;

namespace ChampionsLeague.Models
{
    internal class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void OnBallMoved(int ballX, int ballY)
        {
            Console.WriteLine($"[Player {Name}] Ball moved to ({ballX}, {ballY}). Running towards it!");
            X = ballX;
            Y = ballY;
        }
    }
}
