using ChampionsLeague.Models;

namespace ChampionsLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameEngine = new GameEngine();

            var ball = new Ball { Id = 1, Name = "Official Ball", X = 0, Y = 0 };
            gameEngine.InitializeBall(ball);

            var player1 = new Player { Id = 1, Name = "Messi", X = 10, Y = 10 };
            var player2 = new Player { Id = 2, Name = "Ronaldo", X = 20, Y = 20 };
            var player3 = new Player { Id = 3, Name = "Neymar", X = 15, Y = 15 };

            gameEngine.AddPlayer(player1);
            gameEngine.AddPlayer(player2);
            gameEngine.AddPlayer(player3);

            var referee = new Referee { Id = 1, Name = "John", X = 50, Y = 50 };
            gameEngine.SetReferee(referee);

            var audience1 = new Audience { Section = "North Stand" };
            var audience2 = new Audience { Section = "South Stand" };
            gameEngine.AddAudience(audience1);
            gameEngine.AddAudience(audience2);

            gameEngine.StartGame();

            gameEngine.MoveBall(30, 30);
            gameEngine.MoveBall(45, 60);
            gameEngine.MoveBall(70, 80);

            gameEngine.EndGame();
        }
    }
}
