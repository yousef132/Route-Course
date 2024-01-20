using System.Drawing;
using System.Reflection;
using System.Text;

namespace Session_5
{
	internal partial class Program
	{
		enum WeekDays
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}

		enum Season
		{
			Spring,
			Summer,
			Autumn,
			Winter
		}

		enum Permission
		{
			None = 0,
			Read = 1,
			Write = 2,
			Delete = 4,
			Execute = 8
		}
		enum Colors
		{
			Red,
			Green,
			Blue
		}
		static void Main(string[] args)
		{
			#region QS 1
			//1-	Create an enum called "WeekDays" with the days
			//of the week (Monday to Sunday) as its members.
			//Then, write a C# program that prints out all the days
			//of the week using this enum

			//foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
			//{
			//	Console.WriteLine(day);
			//}

			#endregion


			#region QS 2
			//2.	Define a struct "Person" with properties "Name" and "Age".
			//Create an array of three "Person" objects and populate it with data.
			//Then, write a C# program to display the details of all the persons in
			//the array.
			//Person[] person = new Person[3];

			//person[0] = new Person("Ali", 20);
			//person[1] = new Person("Mona", 15);
			//person[2] = new Person("Omar", 30);

			//foreach (Person p in person)
			//{
			//	Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
			//}



			#endregion

			#region QS 3
			//3.	Create an enum called "Season" with the four seasons
			//(Spring, Summer, Autumn, Winter) as its members. Write a C#
			//program that takes a season name as input from the user and
			//displays the corresponding month range for that season. Note
			//range for seasons ( spring march to may , summer june to august
			//, autumn September to November , winter December to February)

			//Console.Write("Enter a season: ");
			//string season = Console.ReadLine();

			//if (Enum.TryParse(season, true, out Season selectedSeason))
			//{
			//	switch (selectedSeason)
			//	{
			//		case Season.Spring:
			//			Console.WriteLine("Month Range: March to May");
			//			break;

			//		case Season.Summer:
			//			Console.WriteLine("Month Range: June to August");
			//			break;

			//		case Season.Autumn:
			//			Console.WriteLine("Month Range: September to November");
			//			break;

			//		case Season.Winter:
			//			Console.WriteLine("Month Range: December to February");
			//			break;

			//		default:
			//			Console.WriteLine("Invalid season.");
			//			break;
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Invalid season.");
			//}


			#endregion

			#region QS 4
			//    4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
			//●	Create Variable from previous Enum to Add and Remove Permission from variable,
			//check if specific Permission is existed inside variable

			//Permission p = Permission.Read | Permission.Write;

			//Console.WriteLine($"Initial Permissions: {p}");

			//p ^= Permission.Execute;

			//Console.WriteLine($"Permissions after toggling Execute: {p}");

			//p ^= Permission.Write;

			//Console.WriteLine($"Permissions after toggling Write: {p}");

			//bool hasReadPermission = (p & Permission.Read) == Permission.Read;
			//Console.WriteLine($"Has Read Permission: {hasReadPermission}");

			//bool hasDeletePermission = p.HasFlag(Permission.Delete);
			//Console.WriteLine($"Has Delete Permission: {hasDeletePermission}");

			#endregion

			#region QS 5
			//5. Create an enum called "Colors" with the basic colors (Red, Green, Blue)
			//as its members. Write a C# program that takes a color name as input from the
			//user and displays a message indicating whether the input color is a primary color or not.

			//Console.Write("Enter a color name (Red, Green, Blue): ");
			//string inputcolor = Console.ReadLine();

			//if (Enum.TryParse(inputcolor, true, out Colors color))
			//{

			//	if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
			//	{
			//		Console.WriteLine($"{color} is a primary color.");
			//	}
			//	else
			//	{
			//		Console.WriteLine($"{color} is not a primary color.");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Invalid color input.");
			//}

			#endregion


			#region QS 6
			//6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
			//Write a C# program that takes two points as input from the user and calculates the distance
			//between them

			//Console.Write("Enter Point1 X coordinate: ");
			//double x1 = Convert.ToDouble(Console.ReadLine());

			//Console.Write("Enter Point1 Y coordinate: ");
			//double y1 = Convert.ToDouble(Console.ReadLine());


			//Console.Write("Enter Point2 X coordinate: ");
			//double x2 = Convert.ToDouble(Console.ReadLine());

			//Console.Write("Enter Point2 Y coordinate: ");
			//double y2 = Convert.ToDouble(Console.ReadLine());

			//Point p1 = new Point(x1, y1);
			//Point p2 = new Point(x2, y2);

			//double dX = p2.X - p1.X;
			//double dY = p2.Y - p1.Y;

			//         Console.WriteLine((double)Math.Sqrt(dX * dX + dY * dY));
			#endregion

			#region QS 7
			//7. Create a struct called "Person" with properties "Name" and "Age".
			//Write a C# program that takes details of 3 persons as input from the
			//user and displays the name and age of the oldest person.

			//Person[] persons = new Person[3]; 
			//Console.Write("Enter First Person Name : ");
			//persons[0].Name = Console.ReadLine();
   //         Console.Write("Enter First Person Age :");
			//persons[0].Age = int.Parse(Console.ReadLine());

			//Console.Write("Enter Second Person Name : ");
			//persons[1].Name = Console.ReadLine();
			//Console.Write("Enter Second Person Age :");
			//persons[1].Age = int.Parse(Console.ReadLine());


			//Console.Write("Enter Third Person Name : ");
			//persons[2].Name = Console.ReadLine();
			//Console.Write("Enter Third Person Age :");
			//persons[2].Age = int.Parse(Console.ReadLine());

			//Person tmp = persons[0];
			//for (int i = 1; i < persons.Length; i++)
			//{
			//	//I Used Operator Overloading In the Struct
			//	if (persons[i] >= tmp)
			//	{
			//		tmp = persons[i];
			//	}
			//}
   //         Console.WriteLine($"The Oldest Person is {tmp.Name} With Age = {tmp.Age}");

            #endregion
        }
	}
}
