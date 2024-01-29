namespace Advanced_C__02
{
	public delegate T BookDelegate<out T>(Book book);

	public class Book
	{
		public int ISBN { get; set; }
		public string Title { get; set; }

		public string[] Authors { get; set; }

		public DateTime PublicationDate { get; set; }
		public decimal Price { get; set; }

		public Book(int isbn , string title , string[]authors , DateTime publicationdate , decimal price)
		{
			this.ISBN = isbn;
			this.Title = title;
			this.Authors = authors;
			this.PublicationDate = publicationdate;
			this.Price = price;
		}

		public override string ToString()
		{
			return $"ID {ISBN} , Title {Title},Authors {Authors.ToString()},PublicationDate{PublicationDate},Price{Price}";
		}

	}
}
