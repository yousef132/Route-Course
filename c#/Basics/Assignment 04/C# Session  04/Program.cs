using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Text;

namespace C__Session__04
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region QS 1
			//1-Explain the difference between passing (Value type parameters) by
			//value and by reference then write a suitable c# example.

			// when passing parameter by value  a copy of the actual value is passed to the method.the original variables doesn't affected
			// when passing parameter by reference the method recieve a reference to the original variable. the original variables  affected

			//int a =1 , b =2 ;

			// When using the "ref" keyword,
			// variables a and b are swapped; without it, they remain unchanged.		

			//swap(ref a ,ref b );


			#endregion

			#region QS 2
			//2-Explain the difference between passing
			//(Reference type parameters) by value and by reference
			//then write a suitable c# example.

			// when passing reference type by value then
			// we are passing a copy of the reference to the object. 
			// modifications made to the object inside the method will 
			// affect the original object except when reinializing the object

			// when passing reference type by reference
			//then we are passing a reference to the reference
			// all modification will affect the original object

			//int [] arr = { 1, 2, 3, 4, 5, 6, };
			//fun1(arr);
			//fun2 (ref arr);




			#endregion

			#region QS 3
			//int a = 1, b = 2;

			//sum_sub(a, b, out int sum, out int sub);
			//         Console.WriteLine(sum);
			//         Console.WriteLine(sub);
			#endregion

			#region QS 4
			//4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
			//Output should be like
			//Enter a number: 25
			//The sum of the digits of the number 25 is: 7

			//int n = 24;
			//         Console.WriteLine(sumofdigits(n));
			#endregion

			#region QS 5
			//5-	Create a function named "IsPrime",
			//which receives an integer number and retuns true if it is prime, or false if it is not:
			//int n = int.Parse(Console.ReadLine());
			//Console.WriteLine($"{n} is {(IsPrime(n) ? "Prime" : "Not Prime")}");
			#endregion


			#region QS 6
			//6-Create a function named MinMaxArray,
			//to return the minimum and maximum values stored in an array, using reference parameters


			//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

			//MinMaxArray(arr,out int min , out int max);
			//         Console.WriteLine($"Min element  = {min} & Max element = {max}");

			#endregion


			#region QS 7
			//7-Create an iterative (non-recursive) function to calculate the factorial
			//of the number specified as parameter

			//int n = int.Parse(Console.ReadLine());
			//Console.WriteLine($"Factorial of {n} is {Factorial(n)}");

			#endregion


			#region QS 8
			//8-	Create a function named "ChangeChar" to modify a letter in a certain position
			//(0 based) of a string, replacing it with a different letter

			//string s = "Usif"; 
			//Console.WriteLine(ChangeChar(ref s , 2,'e'));

			#endregion


		}

		public static void fun1(int[] arr) 
		{
			arr = new int[] { 2, 3, 3, 5, 5 };
            Console.WriteLine(arr.GetHashCode());
        }
		public static void fun2(ref int[] arr)
		{
			arr = new int[] { 2, 3, 3, 5, 5 };
			Console.WriteLine(arr.GetHashCode());
		}
		public static void swap(ref int a , ref int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}

		public static void sum_sub(int a , int b , out int sum , out int sub)
		{
			sum = a + b;
			sub = a - b; // or b - a
		}


		public static int sumofdigits(int n)
		{
			int sum = 0;
			while(n>0)
			{
				sum += (n % 10);
				n /= 10;
			}
			return sum;

		}

		public static bool IsPrime(int n )
		{
			for( int i = 2; i <=Math.Sqrt(n); i++ )
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			return true;
		}


		public static void MinMaxArray(int[]arr , out int min , out int max )
		{
			min = max = arr[0];
			for(int i = 0; i < arr.Length; i++ )
			{
				min=Math.Min(min, arr[i]);
				max=Math.Max(max, arr[i]);
			}

		}

		public static long Factorial(int n)
		{
			long fact = 1;
			for(int i = 1;i <= n; i++)
			{
				fact *= i;
			}
			return fact;
		}

		public static string ChangeChar( ref string s, int Index, char newChar)
		{

			// I used stringbuilder because it is mutable  while string is immutable
			if (Index < 0 || Index >= s.Length)
			{
				return "Index Is out of string Range ";
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(s);
			stringBuilder[Index] = newChar;
			return stringBuilder.ToString();
		}
	}
}
