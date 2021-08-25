

namespace Demo18_08_2021.DTO
{
	public class DiningTable
	{
		public int TableId { get; set; }

		public string TableName { get; set; }

		public int Status { get; set; }

		public int Floor { get; set; }


		public DiningTable()
		{
			
		}
		public DiningTable(int tableId, string tableName, int floor)
		{
			TableId = tableId;
			TableName = tableName;
			Status = 0;
			Floor = floor;
		}
	}
}
