using ChampionsLeague.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChampionsLeague
{
    internal class GameEngine
    {
        private Ball _ball;
        private List<Player> _players;
        private Referee _referee;
        private List<Audience> _audiences;

        public GameEngine()
        {
            _players = new List<Player>();
            _audiences = new List<Audience>();
        }

        public void InitializeBall(Ball ball)
        {
            _ball = ball;
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
            if (_ball != null)
                _ball.OnBallMoved += player.OnBallMoved;
        }

        public void SetReferee(Referee referee)
        {
            _referee = referee;
            if (_ball != null)
                _ball.OnBallMoved += _referee.OnBallMoved;
        }

        public void AddAudience(Audience audience)
        {
            _audiences.Add(audience);
            if (_ball != null)
                _ball.OnBallMoved += audience.OnBallMoved;
        }

        public void StartGame()
        {
            Console.WriteLine("========== GAME STARTED ==========\n");
        }

        public void MoveBall(int x, int y)
        {
            Console.WriteLine($"\n--- Ball is moving to ({x}, {y}) ---");
            _ball.UpdateBallLocation(x, y);
            Console.WriteLine();
        }

        public void EndGame()
        {
            Console.WriteLine("\n========== GAME ENDED ==========");
        }
    }
}
