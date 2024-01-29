namespace Advanced_C__02
{
	public delegate int StringMethodsDelegate(string name);

	public class StringMethods
	{

		public static void Print(string s)
		{
			Console.WriteLine(s);
		}
		public static int GetCoutOfUpperLetters(string str)
		{
			int count = 0;

			foreach (var ch in str)
			{
				if (char.IsUpper(ch))
				{
					count++;
				}
			}
			return count;
		}
		public static int GetCoutOfLowerLetters(string str)
		{
			int count = 0;

			foreach (var ch in str)
			{
				if (char.IsLower(ch))
				{
					count++;
				}
			}
			return count;
		}
	}

}