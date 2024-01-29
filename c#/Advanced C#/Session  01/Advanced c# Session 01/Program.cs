using System.Runtime.Intrinsics.X86;
using System;

namespace Advanced_c__Session_01
{
	internal class Program
	{
		public static void Main(string[] args)
		{

			#region QS 1 
			//The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
			//And implement the code of this optimized bubble sort algorithm


			//we can make flag to check if any swaps were made during the loop.
			//If no swaps are made, the array is already sorted , then break;
			#endregion

			#region QS 2
			//create a generic Range<T> class that represents a range of values from a
			//minimum value to a maximum value. The range should support basic operations
			//such as checking if a value is within the range and determining the length of the range.
			//Requirements:

			Range<int> range = new Range<int>(10, 100);
			Console.WriteLine(range.IsInRange(30));
			Console.WriteLine(range.Length());

			#endregion

			#region QS 3
			//You are given an ArrayList containing a sequence of elements. try to reverse the
			//order of elements in the ArrayList in-place(in the same arrayList) without using
			//the built-in Reverse. Implement a function that takes the ArrayList as input and
			//modifies it to have the reversed order of elements.


			List<int> Numbers = new List<int>()
			{
				1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
			};

			CommonFunctions<int>.Reverse(Numbers);
			CommonFunctions<int>.PrintList(Numbers);

			List<string> Names = new List<string>()
			{
				"Ali" , "Omar" , "Khalid" , "Mohamed"
			};

			CommonFunctions<string>.Reverse(Names);
			CommonFunctions<string>.PrintList(Names);
			#endregion

			#region QS 4
			//You are given a list of integers. Your task is to find and return a
			//new list containing only the even numbers from the given list

			List<int> nums = new List<int>()
			{
				1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
			};

			var evens = CommonFunctions<int>.EvenNumber(nums);

			foreach (int i in evens)
			{
				Console.WriteLine(i);
			}

			#endregion

			#region QS 5
			//implement a custom list called FixedSizeList<T> with a predetermined capacity.
			//This list should not allow more elements than its capacity and should provide
			//clear messages if one tries to exceed it or access invalid indices.



			FixedSizeLength<int> list = new FixedSizeLength<int>(5);

			list.Add(1);
			list.Add(2);
			list.Add(3);
			list.Add(4);
			list.Add(5);
			list.Add(6); //->Exception

			//int element = list[6]; -> Error
			#endregion

			#region QS 6
			//Given a string, find the first non - repeated character in it and
			//return its index.If there is no such character, return -1.
			//Hint you can use dictionary


			string s1 = "abcdKabcd";
			string s2 = "abcdKKabcd";
            Console.WriteLine(CommonFunctions<int>.FirtNonRepeatedCharacter(s1));// 4
            Console.WriteLine(CommonFunctions<int>.FirtNonRepeatedCharacter(s2));// -1
			#endregion
		}


	}

}
