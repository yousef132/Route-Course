namespace Advanced_c__Session_01
{
	public class Range<T> where T : IComparable
	{
		public T Min { get; set; }
		public T Max { get; set; }
		public Range(T min, T max)
		{
			Min = min;
			Max = max;
		}

		public bool IsInRange(T value) => value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;

		public int Length() => Convert.ToInt32(Max) - Convert.ToInt32(Min);
	}


}
