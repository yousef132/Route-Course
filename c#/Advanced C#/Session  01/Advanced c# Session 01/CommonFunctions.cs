namespace Advanced_c__Session_01
{
	public static class CommonFunctions<T> where T: IComparable
	{
		public static void OptimizedBubbleSort(T[] arr)
		{
			int n = arr.Length;
			bool swapped;

			for (int i = 0; i < n - 1; i++)
			{
				swapped = false;

				for (int j = 0; j < n - i - 1; j++)
				{
					if (arr[i].CompareTo(arr[j+1])==1)
					{
						T temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;

						swapped = true;
					}
				}

				// If no two elements were swapped by inner loop then the array is already sorted
				if (!swapped)
					break;
			}
		}

		public static List<int> EvenNumber(List<int> list)
		{
			List<int> result = new List<int>();
			foreach (var item in list)
			{
				if (item % 2 == 0)
				{
					result.Add(item);
				}
			}
			return result;
		}
		public static void Reverse(List<T> list)
		{
			int l = 0, r = list.Count - 1;

			while (l < r)
			{
				Swap();
				l++;
				r--;
			}


			void Swap()
			{
				T tmp = list[l];
				list[l] = list[r];
				list[r] = tmp;
			}
		}

		public static int FirtNonRepeatedCharacter(string s)
		{
			Dictionary<char, int> freq = new Dictionary<char, int>();
			foreach (char c in s)
			{
				if (freq.ContainsKey(c))
				{
					freq[c]++;
				}
				else
				{
					freq.Add(c, 1);
				}
			}
			int indx = -1;
			for (int i = 0; i < s.Length; i++)
			{
				if (freq[s[i]] == 1)
				{
					indx = i;
					break;
				}
			}
			return indx;
		}


		public static void PrintList(List<T> list)
		{
			foreach (T item in list)
			{
				Console.WriteLine(item);
			}
		}
	}

}
