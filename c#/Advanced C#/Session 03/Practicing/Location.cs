
namespace Practicing
{
	public struct Location
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }

		public override string ToString()
		{
			return $"X : {X} , Y : {Y} , Z : {Z}";
		}


		public static bool operator ==(Location l , Location r)
		{
			return(l.X == r.X && l.Y == r.Y && l.Z == r.Z);
		}

		public static bool operator !=(Location l, Location r)
		{
			return (l.X != r.X || l.Y != r.Y || l.Z != r.Z);
		}
	}
}