namespace Advanced_C__02
{

	public delegate bool CompareDelegate(int a, int b);

	public class SortingAlgo
	{
		public static void BubbleSort(int[] arr, CompareDelegate cd)
		{
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (cd.Invoke(arr[i], arr[j + 1]))
					{
						Swap<int>(ref arr[i], ref arr[j + 1]);
					}
				}
			}
		}

		private static void Swap<T>(ref T a, ref T b)
		{
			T tmp = a;
			a = b;
			b = tmp;
		}
	}
}