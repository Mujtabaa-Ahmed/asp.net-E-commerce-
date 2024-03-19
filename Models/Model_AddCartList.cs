namespace OnlineStore.Models
{
	public class Model_AddCartList
	{
        public string ItemID { get; set; }
		public string ItemCode { get; set; }

		public string ItemName { get; set; }
		public string ItemPrice { get; set; }
		public string ItemQty { get; set; }
	}

	public static class AddList
	{
		public static List<Model_AddCartList> Model_Cart = new List<Model_AddCartList>();
		
    }


}
