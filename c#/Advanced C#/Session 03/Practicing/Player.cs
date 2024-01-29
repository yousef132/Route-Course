
namespace Practicing
{
	public class Player
	{
		public string Team { get; set; }
		public string Name { get; set; }

		// Call back method Match Event Delegate Signature
		public void Run()
		{
            Console.WriteLine($"Player {Name} Is Running.....");
        }
		public override string ToString()
		{
			return $"Name {Name}  , Team {Team}";
		}



	}
}