using System;
using System.Collections.Generic;
using System.Text;

namespace ChampionsLeague.Models
{
    internal class Audience
    {
        public string? Section { get; set; }

        public void OnBallMoved(int ballX, int ballY)
        {
            Console.WriteLine($"[Audience {Section}] Cheering! Ball is at ({ballX}, {ballY})!");
        }
    }
}
