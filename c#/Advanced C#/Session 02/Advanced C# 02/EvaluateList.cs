namespace Advanced_C__02
{

	public delegate bool EvaluatorDelegate(int n);
	public delegate bool GenericEvaluatorDelegate<T>(T n);

	public class EvaluateList
	{
		public static List<T> GetNumbersBasedOnEvaluatorUsingPredicate<T>(List<T> numbers, Predicate<T> ed)
		{
			List<T> result = new List<T>();
			foreach (T n in numbers)
			{
				if (ed(n))
				{
					result.Add(n);
				}
			}
			return result;
		}
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
		public static List<T> GenericGetNumbersBasedOnEvaluator<T> (List<T> numbers , GenericEvaluatorDelegate<T> ed)
		{
			List <T> result = new List<T>();
			foreach(T n in numbers)
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