using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
	public class Class_UserModel
	{
		[BindProperty]
		[Key]
        public int u_id { get; set; }


		[Required]
		[BindProperty]
		public string name { get; set; }

		[Required]
		[BindProperty]
		public string email { get; set; }


		[Required]
		[BindProperty]
		public string pass { get; set; }
	}
}
