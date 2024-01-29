namespace Advanced_C__02
{
	public static class BookFunctions
	{
		public static string GetTitle(Book b) => b.Title;
		public static decimal GetPrice(Book b) => b.Price;

		public static string GetAuthors(Book b)	
		{
			string authors = "";

			foreach(string auth in b.Authors)
			{
				authors += $"{auth} ";
			}
			return authors;
		}

	}
}
