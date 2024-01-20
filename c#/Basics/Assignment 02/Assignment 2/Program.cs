using System.ComponentModel;

namespace Assignment_2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region QS1
			/*
			1- Write a program that allows the user to enter a number then print it.
			 */
			Console.WriteLine("Enter Number :");
			 int number = int.Parse(Console.ReadLine());
			Console.WriteLine($"Your Number is {number}");
			#endregion

			#region Qs2
			//2-Write C# program that Convert a string to an integer, but the string contains
			//non-numeric characters. And mention what will happen 

			// Program will Throw an exception because this string can't be converted to number

			string number2 = "ab23";
			int convertedstring = Convert.ToInt32(number2);
			#endregion


			#region QS3
			//3-Write C# program that Perform a simple arithmetic operation with 
			//floating-point numbers And mention what will happen

			float num1 = 4.9f;
			double num2 = 5.35d;
			//Result will be 10.25
			Console.WriteLine(num1+num2);
			#endregion


			#region QS4
			//4-Write C# program that Extract a substring from a given string.
			string s = Console.ReadLine();
			Console.WriteLine(s.Substring(2,3));
			#endregion

			
			#region QS5
			//5- Write C# program that Assigning one value type variable to
			//	another and modifying the value of one variable and mention
			//	what will happen

			// only The value of num2 will change becuase it is premetive datatype

			int num1 = 4, num2;
			num2 = num1;
			
			num2 += 10;
			#endregion


			#region QS6
			//6- Write C# program that Assigning one reference type variable to
			//	another and modifying the object through one variable and
			//	mention what will happen

			// Two variables will have the same reference so modifying one will automatically update the other.
			Point p1 = new Point();
			p1.x = 1;
			p1.y = 2;

			Point p2 = new Point();
			p2.x = 3;
			p2.y = 4;

			//Now p2 has the reference of p1 
			p2 = p1;

			p1.x = 10;
			p1.y = 11;


            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);


			p1.x=0; p1.y=0;

			Console.WriteLine(p1.x);
			Console.WriteLine(p1.y);
			Console.WriteLine(p2.x);
			Console.WriteLine(p2.y);

			#endregion


			#region QS7
			//7-Write C# program that take two string variables and print 
			//	them as one variable 

			string s1 = "First";
			string s2 = "Second";

			Console.WriteLine(s1+" "+s2);
			#endregion

			#region QS8
			//8- Which of the following statements is correct about the C#.NET 
			//	code snippet given below?



			//B) A value 1 will be assigned to d.

			#endregion


			#region QS9
			//9- Which of the following is the correct output for the C# 
			//	code given below?

			//D) 6 1

			#endregion

			#region QS10
			//10 - What will be the output of the C# code given below?

			//2 + 5 + " " + 7

			//D) 7 7

			#endregion
		}
	}
}
