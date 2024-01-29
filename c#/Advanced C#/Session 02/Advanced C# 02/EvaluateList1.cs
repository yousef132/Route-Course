namespace Advanced_C__02
{
	public class EvaluateList<T>
	{
		public static List<int> GetNumbersBasedOnEvaluator(List<int> numbers, EvaluatorDelegate ed)
		{
			List<int> result = new List<int>();
			foreach (int n in numbers)
			{
				if (ed(n))
				{
					result.Add(n);
				}
			}
			return result;
		}
	}
}