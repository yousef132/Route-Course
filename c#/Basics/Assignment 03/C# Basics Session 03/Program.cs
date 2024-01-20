using System.ComponentModel;
using System.Xml.Linq;

namespace C__Basics_Session_03
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region QS1

			//1 - Write a program that takes a number from the user then
			//print yes if that number can be divided by 3 and 4 otherwise print no.

			//int num1 = int.Parse(Console.ReadLine());
			//if (num1 % 3 == 0 && num1 % 4 == 0)
			//{
			//	Console.WriteLine("YES");
			//}
			//else
			//{
			//	Console.WriteLine("NO");
			//}
			#endregion

			#region QS2
			//2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

			//int num2  = int.Parse(Console.ReadLine());	
			//if(num2<0)
			//{
			//             Console.WriteLine("Negative");
			//         }
			//else
			//{
			//	Console.WriteLine("Positive");
			//}

			#endregion

			#region QS3
			//3 - Write a program that takes 3 integers from the user then
			//prints the max element and the min element.

			//int num3 = int.Parse(Console.ReadLine());
			//int num4 = int.Parse(Console.ReadLine());
			//int num5 = int.Parse(Console.ReadLine());

			//Console.Write($"MIN NUM is ");
			//if (num3 <= num4 && num3 <= num5)
			//{
			//	Console.WriteLine(num3);
			//}
			//else if (num4 <= num5 && num4 <= num3)
			//{
			//	Console.WriteLine(num4);
			//}
			//else
			//{
			//	Console.WriteLine(num5);
			//}
			//Console.Write($"MAX NUM is ");
			//if (num3 >= num4 && num3 >= num5)
			//{
			//	Console.WriteLine(num3);
			//}
			//else if (num4 >= num5 && num4 >= num3)
			//{
			//	Console.WriteLine(num4);
			//}
			//else
			//{
			//	Console.WriteLine(num5);
			//}

			#endregion

			#region QS4
			//4- Write a program that allows the user to insert
			//an integer number then check If a number is even or odd.

			//int num = int.Parse(Console.ReadLine());
			//if(num%2==0 ) 
			//{
			//	Console.WriteLine("Even");
			//}
			//else
			//{
			//	Console.WriteLine("Odd");
			//}
			#endregion

			#region QS5
			//5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u)
			//then print (vowel) otherwise print (consonant).
			//char Char = char.Parse(Console.ReadLine());


			//if (Char == 'a' || Char == 'e' || Char == 'i' || Char == 'o' || Char == 'u')
			//{
			//	Console.WriteLine("Vowel");
			//}
			//else
			//{
			//	Console.WriteLine("Consonant");
			//}
			#endregion

			#region QS6
			//6- Write a program that allows the user to insert an integer
			//then print all numbers between 1 to that number.

			//int num = int.Parse(Console.ReadLine());

			//for(int i = 1; i <= num; i++)
			//{
			//             Console.WriteLine(i);
			//         }
			#endregion

			#region QS7
			//7 - Write a program that allows the user to insert an integer then
			//print a multiplication table up to 12.

			//int num = int.Parse(Console.ReadLine());

			//for (int i = 1; i <= 12; i++)
			//{
			//	Console.WriteLine(num * i);
			//}

			#endregion

			#region QS8
			//8- Write a program that allows to user to insert number then
			//print all even numbers between 1 to this number

			//int num = int.Parse(Console.ReadLine());

			//for(int i = 1; i <= num; i++)
			//{
			//	if(i% 2 == 0)
			//	Console.WriteLine(i);
			//}

			#endregion

			#region QS9
			//9- Write a program that takes two integers then prints the power

			//int num = int.Parse(Console.ReadLine());
			//int num1 = int.Parse(Console.ReadLine());
			//int res = 1;
			//for (int i = 0; i < num1; i++)
			//{
			//	res *= num;
			//}
			//Console.WriteLine(res);


			#endregion

			#region QS10
			//10 - Write a program to enter marks of five subjects and calculate total,
			//average and percentage.

			//int[] marks = new int[5];
			//double Total = 0, avg = 0, per = 0;
			//for (int i = 0; i < marks.Length; i++)
			//{
			//	marks[i] = int.Parse(Console.ReadLine());
			//	Total += marks[i];

			//}
			//avg = Total / 5;
			//per = (Total / 500) * 100;
			//Console.WriteLine($"Total marks {Total}");
			//Console.WriteLine($"Average Marks {avg}");
			//Console.WriteLine($"Percentage  {per}");
			#endregion

			#region Qs11
			//11- Write a program to input the month number and print the number of days in that month.
			//int monthNumber = int.Parse(Console.ReadLine());
			//switch (monthNumber)
			//{
			//	case 1:  
			//	case 3:  
			//	case 5:  
			//	case 7:  
			//	case 8:  
			//	case 10: 
			//	case 12: 
			//                 Console.WriteLine(31);
			//                 break;

			//	case 4:  
			//	case 6:  
			//	case 9:  
			//	case 11: 
			//		Console.WriteLine(30);
			//		break;

			//	case 2:  
			//		Console.WriteLine(28);
			//		break;

			//	default:
			//		Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
			//		return;
			//}
			#endregion

			#region QS12
			//12- Write a program to create a Simple Calculator.

			//         Console.WriteLine("Enter Two Numbers");
			//         int num1 = int.Parse(Console.ReadLine());
			//int num2 = int.Parse(Console.ReadLine());

			//         Console.WriteLine("Choose Number");
			//Console.WriteLine("1. (+)");
			//Console.WriteLine("2. (-)");
			//Console.WriteLine("3. (/)");
			//Console.WriteLine("4. (*)");
			//Console.WriteLine("5. (%)");
			//int choice = int.Parse(Console.ReadLine());

			//switch(choice)
			//{
			//	case 1:
			//		Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
			//		break;
			//	case 2:
			//		Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
			//		break;
			//             case 3:
			//		Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
			//		break;
			//	case 4:
			//		Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
			//		break;
			//	case 5:
			//		Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
			//		break;

			//	default:
			//		Console.WriteLine("Invalid Number Try Again");
			//		return;
			//}


			#endregion

			#region QS13
			//13- Write a program to allow the user to enter a string and print the REVERSE of it.
			//Console.WriteLine("Enter a  String");
			//string s = Console.ReadLine();

			//Console.WriteLine("Reversed String");
			//for(int i = s.Length-1; i>=0; i--) 
			//{
			//	Console.Write(s[i]);
			//         }
			#endregion

			#region QS14
			//14- Write a program to allow the user to enter int and print the REVERSED of it.

			//int x = int.Parse(Console.ReadLine());

			//while (x > 0)
			//{
			//	Console.Write(x % 10);
			//	x /= 10;
			//}

			#endregion

			#region QS15
			//15- Write a program in C# Sharp to find prime numbers within a range of numbers.

			//Console.WriteLine("Enter start range and end range");
			//int st = int.Parse(Console.ReadLine());
			//int end = int.Parse(Console.ReadLine());

			//for (int i = st; i <= end; i++)
			//{
			//	if(i==1)
			//	{
			//		continue;
			//	}

			//	bool flage = false; // check if Number is prime
			//	for (int j = 2; j <= Math.Sqrt(i); j++)
			//	{
			//		if (i % j == 0)
			//		{
			//			flage = true;
			//		}
			//	}

			//	if (!flage)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}

			#endregion

			#region QS16
			//16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.

			//int num = int.Parse(Console.ReadLine());
			//string ans = "";
			//while (num > 0)
			//{
			//	ans += (num % 2);
			//	num /= 2;
			//}
			//for(int i = ans.Length-1; i >= 0; i--)
			//{
			//	Console.Write(ans[i]);
			//}
			#endregion

			#region QS17
			//17- Create a program that asks the user to input three points (x1, y1),
			//(x2, y2), and (x3, y3), and determines whether these

			//Console.WriteLine("Enter  (x1, y1):");
			//int x1 = int.Parse(Console.ReadLine());
			//int y1 = int.Parse(Console.ReadLine());

			//Console.WriteLine("Enter  (x2, y2):");
			//int x2 = int.Parse(Console.ReadLine());
			//int y2 = int.Parse(Console.ReadLine());

			//Console.WriteLine("Enter  (x3, y3):");
			//int x3 = int.Parse(Console.ReadLine());
			//int y3 = int.Parse(Console.ReadLine());

			//double slope1 = (double)(y2 - y1) / (x2 - x1);
			//double slope2 = (double)(y3 - y2) / (x3 - x2);

			//if (slope1 == slope2)
			//{
			//	Console.WriteLine("The points lie on the same line.");
			//}
			//else
			//{
			//	Console.WriteLine("The points do not lie on the same line.");
			//}
			#endregion

			#region QS18

			//18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
			//-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
			//- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
			//- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
			//- If the worker takes more than 5 hours, they are required to leave the company.
			//To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

			//Console.WriteLine("Enter the Time taken for the task");
			//double time = double.Parse(Console.ReadLine());
			//if (time >= 2 && time <= 3)
			//{
			//	Console.WriteLine("high efficient");
			//}
			//else if (time > 3 && time <= 4)
			//{
			//	Console.WriteLine("Incease Your Speed");
			//}
			//else if (time > 4 && time <= 5)
			//{
			//	Console.WriteLine("Train to Enhance Your Speed");
			//}
			//else if (time > 5)
			//{
			//	Console.WriteLine("Leave the company");
			//}
			#endregion

			#region QS19
			//19- . Write a program that prints an identity matrix using for loop,
			//in other words takes a value n from theuser and shows the identity table of size n * n.

			//int n = int.Parse(Console.ReadLine());
			//int[,] mat = new int[n,n];

			//for (int i = 0; i < mat.GetLength(0); i++)
			//{
			//	for (int j = 0; j < mat.GetLength(1); j++)
			//	{
			//		if(i== j)
			//		{
			//			mat[i, j] = 1;
			//		}
			//		Console.Write(mat[i, j]);
			//	}
			//	Console.WriteLine();
			//}
			#endregion

			#region QS20
			//20- Write a program in C# Sharp to find the sum of all elements of the array.
			//int sum = 0;
			//int[]arr = { 1, 2, 3 ,4,5,6,7,8};
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	sum += arr[i];
			//}
			//         Console.WriteLine(sum);
			#endregion

			#region QS21
			////21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

			//Assuming two arrays are sorted
			//int[] arr1 = { 1, 2, 2, 5 };
			//int[] arr2 = { 1, 10, 11, 100 };
			//int[] arr3 = new int[8];

			//int pointer1 = 0, pointer2 = 0;
			//for (int i = 0; i < 8; i++)
			//{
			//	if (pointer1 < arr1.Length)
			//	{
			//		if (pointer2 == arr2.Length || arr1[pointer1] <= arr2[pointer2])
			//		{
			//			arr3[i] = arr1[pointer1];
			//			pointer1++;
			//			continue;
			//		}
			//	}
			//	if (pointer2 < arr2.Length)
			//	{
			//		if (pointer1 == arr1.Length || arr1[pointer1] >= arr2[pointer2])
			//		{
			//			arr3[i] = arr2[pointer2];
			//			pointer2++;
			//		}
			//	}
			//}

			//for (int i = 0; i < arr3.Length; i++)
			//{
			//	Console.Write(arr3[i]);
			//	Console.Write(' ');
			//}
			#endregion

			#region QS22
			//22- Write a program in C# Sharp to count the frequency of each element of an array.
			//int[] arr = { 2, 5, 6, 7, 5, 5, 5, 5, 2, 2, 2, 1, 89, 1 };
			//int mx = arr[0];
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	if (arr[i] > mx)
			//	{
			//		mx = arr[i];
			//	}
			//}

			//int[] freq = new int[mx + 1];
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	freq[arr[i]]++;
			//}

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	Console.WriteLine($"Frequency of Number {arr[i]} = {freq[arr[i]]}");
			//}
			#endregion

			#region QS23
			//23- Write a program in C# Sharp to find maximum and minimum element in an array
			//int[] arr = { 1, 2, 6, 89, 22, 4, 7, 8, 6 };
			//int mn = arr[0];
			//int mx = arr[0];
			//foreach (int i in arr)
			//{
			//	if (mn > i)
			//	{
			//		mn = i;
			//	}
			//	if(mx<i)
			//	{
			//		mx = i;
			//	}
			//}
			//         Console.WriteLine($"Min Num {mn}");
			//         Console.WriteLine($"Man Num {mx}");

			#endregion

			#region QS24
			//24- Write a program in C# Sharp to find the second largest element in an array.
			//int[] arr = { 1, 2, 6, 454, 7, 98, 5 };
			//int mn = int.MaxValue;
			//int smn = mn;

			////to identify first min element by it's index  for case of (first min = second min) to deffrintiate between them by index
			//int IndexofMin = -1;

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	if (arr[i] < mn)
			//	{
			//		// get min element with it's index
			//		mn = arr[i];
			//		IndexofMin = i; 
			//	}
			//}

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	// get min value which it's index != IndexofMin 
			//	if (arr[i] < smn && i != IndexofMin)
			//	{
			//		smn = arr[i];
			//	}
			//}
			//Console.WriteLine(smn);


			#endregion

			#region QS 25
			//Consider an Array of Integer values with size N, having values as    
			//	in this Example

			int n = int.Parse(Console.ReadLine());

			int[] arr = new int[n];

			for (int i = 0; i < n; i++)
				arr[i] = int.Parse(Console.ReadLine());

			#region First Approach with complexity = O(n2)

			int ans = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				int tmp2 = 0, max = 0;
				for (int j = 0; j < arr.Length; j++)
				{
					if (arr[i] == arr[j])
					{
						tmp2 = j - i - 1;
						if (tmp2 > max) max = tmp2;
					}
				}
				ans = (ans < max) ? max : ans;
			}
			Console.WriteLine(ans);

			#endregion


			//plz read this approach 
			#region Second Approach with Better complexity O(n)
			Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
			for (int i = 0; i < n; i++)
			{
				if (dic.ContainsKey(arr[i]))
				{
					dic[arr[i]].Add(i);
				}
				else
				{
					dic.Add(arr[i], new List<int>());
					dic[arr[i]].Add(i);
				}
			}

			// summation of iterations = n
			//0 -> 1 2 3 8 (8-1-1)
			//7 -> 0 6 9   (9-0-1) -> ans
			//5 -> 4 7 10  (10-4-1)
			//6 -> 5
			//3 -> 11

			int tmp = 0;
			foreach (KeyValuePair<int, List<int>> kvp in dic)
			{
				if (kvp.Value.Count > 1)
				{
					tmp = kvp.Value[kvp.Value.Count - 1] - kvp.Value[0] - 1;
					ans = Math.Max(ans, tmp);
				}
			}
			Console.WriteLine(ans);

			#endregion



			#endregion

			#region QS 26
			//26- Given a list of space separated words, reverse the order of the words.

			//string s = Console.ReadLine();
			//string[] arr = s.Split(' ');

			//for (int i = arr.Length-1; i >=0 ; i--)
			//{
			//	Console.Write(arr[i] + " ");
			//}
			#endregion

			#region QS 27
			//27 - Write a program to create two multidimensional arrays of same size.
			//Accept value from user and store them in first array. Now copy all the
			//elements of first array on second array and print second array.

			//int n = int.Parse(Console.ReadLine());
			//int[,] matrix = new int[n,n];
			//int[,] copy = new int[n,n];

			//for (int i = 0; i < matrix.GetLength(0); i++)
			//{
			//	for (int j = 0; j < matrix.GetLength(1); j++)
			//	{
			//		matrix[i, j] = int.Parse(Console.ReadLine());
			//		copy[i, j] = matrix[i, j];
			//	}
			//}
			//for (int i = 0; i < matrix.GetLength(0); i++)
			//{
			//	for (int j = 0; j < matrix.GetLength(1); j++)
			//	{
			//		Console.Write(copy[i, j]);
			//		Console.Write(' ');
			//	}
			//	Console.WriteLine();
			//}



			#endregion

			#region QS 28

			//28- Write a Program to Print One Dimensional Array in Reverse Order

			//int[]arr = { 1, 2, 3 ,5,6,9,78,1,98};

			//for(int i = arr.Length-1; i >= 0; i--)
			//{
			//	Console.Write(arr[i]);
			//	Console.Write(' ');

			//}
			#endregion
		}
	}
}
