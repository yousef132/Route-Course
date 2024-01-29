namespace Advanced_C__02
{

	namespace Advanced_C__02
	{
		public static class LibraryEngine
		{
			public static void ProcessBook<T>(List<Book> books, BookDelegate<T> bd)
			{
				foreach (Book book in books)
				{
					Console.WriteLine(bd(book));
				}
			}
		}

	}

}