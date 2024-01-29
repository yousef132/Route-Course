
namespace Practicing
{

	internal class Program
	{
		static void Main(string[] args)
		{


			Ball ball = new Ball();

			Player p1 = new Player() { Name = "Pedri", Team = "Barca" };
			Player p2 = new Player() { Name = "Messi", Team = "Barca" };
			Player p3 = new Player() { Name = "CR7", Team = "RM" };

			Refree r = new Refree() { Name = "Ibrahem Nour Eldin" };

			ball.BallLocation = new Location() { X = 10, Y = 20 , Z = 30 };


			// Registeration 
			// Add Pointer To Subsc. Call back Methods To Publisher Event Invocation List
			ball.OnLocatoinChanged += p1.Run;
			ball.OnLocatoinChanged += p2.Run;
			ball.OnLocatoinChanged += r.Look;

			ball.BallLocation = new Location() { Z = 10, X = 20 , Y = 10 };


			ball.OnLocatoinChanged -= p1.Run;
            Console.WriteLine("=========================");
            ball.BallLocation = new Location()
			{
				X = 10 , Y = 30, Z = 30
			};




		}

	}
}