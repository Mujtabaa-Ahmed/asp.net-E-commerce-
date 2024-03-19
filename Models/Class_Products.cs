using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
	public class Class_Products
	{

		[BindProperty]
		[Key]
		public int p_id { get; set; }


		[Required]
		[BindProperty]
		public string p_name { get; set; }

		[Required]
		[BindProperty]
		public string p_desc { get; set; }

		[Required]
		[BindProperty]
		public string p_price_old { get; set; }

		[Required]
		[BindProperty]
		public string p_price{ get; set; }

		[Required]
		[BindProperty]
		public string p_img_1 { get; set; }

		[Required]
		[BindProperty]
		public string p_img_2 { get; set; }

		[Required]
		[BindProperty]
		public string p_img_3 { get; set; }

		[Required]
		[BindProperty]
		public int sub_cat_id { get; set; }
	}
}
