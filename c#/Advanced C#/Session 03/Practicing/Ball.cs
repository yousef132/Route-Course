
namespace Practicing
{
	public class Ball
	{
		public int Id { get; set; }

		Location ballLocation;

		public Location BallLocation
		{
			get => ballLocation;

			set
			{
				if (value != ballLocation)
				{
					ballLocation = value;
					// Loop Through InvocationList , Call Subsc. Call Back Methods
					//Player p = new Player();
					//OnLocatoinChanged += p.Run;
					OnLocatoinChanged?.Invoke();
				}

			}
		}

		// Declare Event
		public event Action OnLocatoinChanged;

		public override string ToString()
		{
			return $"Ball {Id} , Location {ballLocation}";
		}


	}
}