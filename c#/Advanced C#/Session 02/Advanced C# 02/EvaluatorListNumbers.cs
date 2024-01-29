namespace Advanced_C__02
{
	public static class EvaluatorListNumbers
	{
		public static bool CheckOdd(int n) => n % 2 != 0;
		public static bool CheckEven(int n) => n % 2 == 0;
		public static bool CheckBySeven(int n) => n % 7 == 0;
		public static bool CheckForLength(string s) => s.Length == 4;
	}
}