using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
	public class Class_Categories
	{

		[BindProperty]
		[Key]
		public int cat_id { get; set; }


		[Required]
		[BindProperty]
		public string cat_name { get; set; }

		[Required]
		[BindProperty]
		public string cat_status { get; set; }

		[Required]
		[BindProperty]
		public int show_menu { get; set; }



	}
}
