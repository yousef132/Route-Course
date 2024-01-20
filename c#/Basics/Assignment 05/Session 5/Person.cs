namespace Session_5
{
	internal partial class Program
	{
		struct Person
		{
			public string Name;
			public int Age;

            public Person(string name, int age)
            {
                Name = name;
				Age = age;
            }

			public static bool operator >=(Person p1 , Person p2)
			{
				return p1.Age>= p2.Age;
			}
			public static bool operator <=(Person p1, Person p2)
			{
				return p1.Age <= p2.Age;
			}
		}
	}
}
