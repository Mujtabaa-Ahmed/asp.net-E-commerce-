using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
	public class Class_subcategories
	{
		[BindProperty]
		[Key]
		public int sub_cat_id { get; set; }


		[Required]
		[BindProperty]
		public string sub_cat_name { get; set; }

		[Required]
		[BindProperty]
		public int cat_id { get; set; }

		[Required]
		[BindProperty]
		public string sub_cat_status { get; set; }

	}
}
