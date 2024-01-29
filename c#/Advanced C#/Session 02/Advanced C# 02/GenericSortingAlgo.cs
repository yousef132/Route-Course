namespace Advanced_C__02
{		
	public delegate TResult GenericCompareDelegate<in T1, in T2, out TResult>(T1 a, T2 b);

	public class GenericSortingAlgo<T>
	{

		public static void BubbleSort(T[] arr, GenericCompareDelegate<T,T ,bool> cd)
		{
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (cd.Invoke(arr[i], arr[j + 1]))
					{
						Swap(ref arr[i], ref arr[j + 1]);
					}
				}
			}
		}
		public static void BubbleSortUsingFunc(T[] arr, Func<T,T ,bool> cd)
		{
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - i - 1; j++)
				{
					if (cd.Invoke(arr[i], arr[j + 1]))
					{
						Swap(ref arr[i], ref arr[j + 1]);
					}
				}
			}
		}

		private static void Swap(ref T a, ref T b)
		{
			T tmp = a;
			a = b;
			b = tmp;
		}
	}
}