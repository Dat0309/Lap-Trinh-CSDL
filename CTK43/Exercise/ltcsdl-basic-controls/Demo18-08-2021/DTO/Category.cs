namespace Demo18_08_2021.DTO
{
	public class Category
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public Category()
		{

		}

		public Category(int id, string name)
		{
			Id = id;
			Name = name;
		}
	}
}