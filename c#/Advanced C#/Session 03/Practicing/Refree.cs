
namespace Practicing
{
	public class Refree
	{
		public string Name { get; set; }

		// Call back method Match Event Delegate Signature
		public  void Look()
		{
            Console.WriteLine($"Refree {Name} Is Looking At the ball");
        }
		public override string ToString()
		{
			return $"Name {Name} ";
		}



	}
}