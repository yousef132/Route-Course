namespace Advanced_c__Session_01
{
	public class FixedSizeLength<T>
	{
		private T[] arr;
		private int cur;
		public FixedSizeLength(int size)
		{
			arr = new T[size];
			cur = 0;
		}

		public void Add(T item)
		{
			if(cur < arr.Length)
			{
				arr[cur++] = item;
			}

			else
			{
				throw new FullArrayException();
			}
		}

		public T Get(int index)
		{
			if(index < 0 || index >= arr.Length)
			{
				throw new IndexOutOfRangeException();
			}
			return arr[index];
		}
	}

}
