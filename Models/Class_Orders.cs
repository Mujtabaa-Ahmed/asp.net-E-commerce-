using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Class_Orders
    {
        [BindProperty]
        [Key]
        public int Order_Id { get; set; }
        [BindProperty]
        [Required]
        public string Order_userId { get; set; }
        [BindProperty]
        [Required]
        public string Order_Date { get; set; }
        [BindProperty]
        [Required]
        public string Order_InvoiceNumber { get; set; }
        [BindProperty]
        [Required]
        public string Order_toatlAmount { get; set; }
    }
}
