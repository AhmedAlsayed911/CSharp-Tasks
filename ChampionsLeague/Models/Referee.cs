using System;
using System.Collections.Generic;
using System.Text;

namespace ChampionsLeague.Models
{
    internal class Referee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void OnBallMoved(int ballX, int ballY)
        {
            Console.WriteLine($"[Referee {Name}] Monitoring ball at ({ballX}, {ballY}). Watching closely!");
        }
    }
}
