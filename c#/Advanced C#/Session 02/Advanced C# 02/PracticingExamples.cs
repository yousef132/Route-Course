namespace Advanced_C__02
{
	public static class PracticingExamples
	{
		public static void Main()
		{
			#region Part 1

			//StringMethodsDelegate stringmethod = StringMethods.GetCoutOfUpperLetters;
			//stringmethod += StringMethods.GetCoutOfLowerLetters;
			//int count = stringmethod.Invoke("AhMed");

			////////////////////////////////////

			//int[] nums = { 8, 7, 3, 1, 6, 4, 2, 4 };
			//SortingAlgo.BubbleSort(nums, CompareToMethods.LessThan);
			//SortingAlgo.BubbleSort(nums, CompareToMethods.GreaterThan);

			////////////////////////////////////////////

			//List<int> list = new List<int>() { 1, 2, 8, 5, 6, 8, 2, 7, 6, 7, 8, 2, 77, 41 };

			//EvaluatorDelegate ed = EvaluatorListNumbers.CheckEven;

			//List<int> result = EvaluateList.GetNumbersBasedOnEvaluator(list, ed);
			////result = EvaluateList.GetNumbersBasedOnEvaluator(list, EvaluatorListNumbers.CheckOdd);
			////result = EvaluateList.GetNumbersBasedOnEvaluator(list, EvaluatorListNumbers.CheckEven);
			//foreach (int n in result)
			//	Console.WriteLine(n);


			//////////////////////////////////

			//int[] numbers = { 5, 9, 8, 2, 4, 2, 4, 2, 8, 3 };
			//GenericCompareDelegate<int, int, bool> comparedelegate = CompareToMethods.GreaterThan;

			//GenericSortingAlgo<int>.BubbleSort(numbers, comparedelegate);

			//foreach (int n in numbers)
			//	Console.WriteLine(n);

			//////////////////////////////////////////////

			//List<string> names = new List<string>() { "ali", "Omar", "Yousef" };
			//GenericEvaluatorDelegate<string> evaluator = EvaluatorListNumbers.CheckForLength;

			//var r = EvaluateList.GenericGetNumbersBasedOnEvaluator(names, evaluator);

			//foreach (string n in r)
			//	Console.WriteLine(n);


			//////////////////////////////////////////

			//// Using Generic Built-In Delegates

			////Predicate

			//List<int> arr = new List<int> { 5, 9, 8, 5, 8, 6, 4, 7, 8, 7, 8, 8, 8 };
			//Predicate<int> evaluator1 = EvaluatorListNumbers.CheckEven;

			//var res = EvaluateList.GetNumbersBasedOnEvaluatorUsingPredicate(arr, evaluator1);


			//// Func

			//int[] nums2 = { 8, 7, 3, 1, 6, 4, 2, 4 };
			//GenericSortingAlgo<int>.BubbleSortUsingFunc(nums, CompareToMethods.LessThan);
			//GenericSortingAlgo<int>.BubbleSortUsingFunc(nums, CompareToMethods.GreaterThan);

			//foreach (int n in nums2)
			//	Console.WriteLine(n);


			//// Action

			//Action<string> action = StringMethods.Print;
			//action.Invoke("ali");



			//// Anonymous Method 

			//Action<string> action2 = delegate (string name)
			//{
			//	Console.WriteLine("Hello" + name);
			//};
			//Action<string> action3 = (string name) => { Console.WriteLine("Hello" + name); };

			//Func<int, string> func = (int i) => i.ToString();




			#endregion

			#region Part 2 

			//List<Book> books = new List<Book>();

			//books.Add(new Book(123456, "Book1", new string[] { "Ali" }, DateTime.Parse("1925-04-10"), 19.99m));
			//books.Add(new Book(789012, "Book2", new string[] { "Mohamed Ali" }, DateTime.Parse("1960-07-11"), 15.50m));
			//books.Add(new Book(345678, "Book3", new string[] { "Omar Osma" }, DateTime.Parse("1949-06-08"), 12.75m));
			//books.Add(new Book(901234, "Book4", new string[] { "Yousef Saad" }, DateTime.Parse("1951-07-16"), 14.99m));
			//books.Add(new Book(567890, "Book5", new string[] { "Mohamed Khalid" }, DateTime.Parse("1813-01-28"), 10.25m));

			//// Change the delegate type to BookDelegate<decimal>
			//BookDelegate<string> bd = BookFunctions.GetTitle;

			//LibraryEngine.ProcessBook<string>(books, bd);
			#endregion
		}
	}
}