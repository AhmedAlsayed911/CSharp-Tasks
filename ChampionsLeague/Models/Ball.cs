using System;
using System.Collections.Generic;
using System.Text;

namespace ChampionsLeague.Models
{
    internal class Ball
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public event Action<int, int>? OnBallMoved;

        public void UpdateBallLocation(int x , int y)
        {
            X = x;
            Y = y;
            OnBallMoved?.Invoke(x, y);
        }

    }
}
