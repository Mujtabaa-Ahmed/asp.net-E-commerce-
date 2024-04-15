using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Models
{
    public class Class_Orders_Details
    {
        [BindProperty]
        [Key]
        public int Orders_details_id { get; set; }
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
        public string Orders_Details_product { get; set; }
        [BindProperty]
        [Required]
        public string Orders_details_Product_price { get; set; }
        [BindProperty]
        [Required]
        public string Orders_details_Product_Qty { get; set; }
    }
}
