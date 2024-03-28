using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.DB;
using OnlineStore.Models;
using System.Diagnostics;
using System.IO;

namespace OnlineStore.Controllers
{
	public class HomeController : Controller
	{
		private Db_Class _DBContext;
		private readonly ILogger<HomeController> _logger;
		public ClassCategeoryModel classCategeoryModels = new ClassCategeoryModel();
		
        public HomeController(ILogger<HomeController> logger, Db_Class cntx)
		{
			_logger = logger;
			_DBContext = cntx;
			classCategeoryModels.SetcatItems = _DBContext.tbl_categories.ToList();
			classCategeoryModels.SetcatItemsMenu= _DBContext.tbl_categories.Where(item => item.cat_status == "Active" && item.show_menu == 1).ToList();
			classCategeoryModels.SubCat = _DBContext.tbl_sub_cat.ToList();
		}

		[HttpPost]
		public IActionResult userlogin()
		{
			

			string getEmail = Request.Form["Email"].ToString();
			string getPassword = Request.Form["Pass"].ToString();
			List<Class_UserModel> getUser = _DBContext.tbl_users.Where(u => u.email == getEmail && u.pass == getPassword).ToList();
			if(getUser.Count > 0)
			{
				HttpContext.Session.SetString("UID", getUser[0].u_id.ToString());
				HttpContext.Session.SetString("FULLNAME", getUser[0].name.ToString());
				ClassSessionUser.UserId = getUser[0].u_id.ToString();
				ClassSessionUser.UserFullName = getUser[0].name.ToString();
				return Content("success");
			}
			else
			{
				return Content("invalid");
			}
			
		}


		

		[HttpGet]
		public IActionResult Products(string catid,string subcatid)
		{
			List<Class_Products> productList = new List<Class_Products>();
			
			if (catid != null)
			{
				productList = _DBContext.tbl_products
							   .Join(_DBContext.tbl_sub_cat,
									 product => product.sub_cat_id,
									 subcategory => subcategory.sub_cat_id,
									 (product, subcategory) => new { product, subcategory })
							   .Join(_DBContext.tbl_categories,
									 combined => combined.subcategory.cat_id,
									 category => category.cat_id,
									 (combined, category) => new { combined.product, combined.subcategory, category })
							   .Where(combined => combined.category.cat_id == Int32.Parse(catid))
							   .Select(combined => new Class_Products
							   {
								   p_id = combined.product.p_id,
								   p_name = combined.product.p_name,
								   p_desc = combined.product.p_desc,
								   p_price = combined.product.p_price,
								   p_price_old = combined.product.p_price_old,
								   p_img_1 = combined.product.p_img_1,
								   p_img_2 = combined.product.p_img_2,
								   p_img_3 = combined.product.p_img_3,
								   sub_cat_id = combined.product.sub_cat_id
							   })
							   .ToList();
				classCategeoryModels.Products = productList;
			}
			if(subcatid != null)
			{
				productList = _DBContext.tbl_products
							   .Join(_DBContext.tbl_sub_cat,
									 product => product.sub_cat_id,
									 subcategory => subcategory.sub_cat_id,
									 (product, subcategory) => new { product, subcategory })
							   .Where(combined => combined.subcategory.sub_cat_id == Int32.Parse(subcatid))
							   .Select(combined => new Class_Products
							   {
								   p_id = combined.product.p_id,
								   p_name = combined.product.p_name,
								   p_desc = combined.product.p_desc,
								   p_price = combined.product.p_price,
								   p_price_old = combined.product.p_price_old,
								   p_img_1 = combined.product.p_img_1,
								   p_img_2 = combined.product.p_img_2,
								   p_img_3 = combined.product.p_img_3,
								   sub_cat_id = combined.product.sub_cat_id
							   })
							   .ToList();
				classCategeoryModels.Products = productList;
			}
			ViewBag.subcat = subcatid;


			return View(classCategeoryModels) ;
		}
		public IActionResult logout()
		{
			HttpContext.Session.Clear();
			ClassSessionUser.UserId = "";
			ClassSessionUser.UserFullName = "";
			return RedirectToAction("index", "Home");
		}

		[HttpPost]
		public IActionResult createuser()
		{
			string getName = Request.Form["NM"].ToString();
			string getEmail = Request.Form["Email"].ToString();
			string getPass = Request.Form["Pass"].ToString();

			List<Class_UserModel> getUser = _DBContext.tbl_users.Where(u => u.email == getEmail).ToList();
			if(getUser.Count > 0)
			{
				
				return Content("already");
			}
			else
			{
				Class_UserModel UserObjecta = new Class_UserModel()
				{
					name = getName,
					email = getEmail,
					pass = getPass
				};
				_DBContext.tbl_users.Add(UserObjecta);
				_DBContext.SaveChanges();
				return Content("success");
			}

			

			
		}

		[HttpPost]
		public IActionResult addcart()
		{

			string getItemID = Request.Form["item_code"].ToString();  //5
			string getItemName = Request.Form["item_name"].ToString();
			string getItemPrice = Request.Form["item_price"].ToString();
			string getsubcatId = Request.Form["seturl"].ToString();
			string getItemQty = "1";  //10

			bool CheckItemCart = false;
			for (int i = 0; i < AddList.Model_Cart.Count; i++)
			{
				if (AddList.Model_Cart[i].ItemID.ToString().Equals(getItemID))
				{
					AddList.Model_Cart[i].ItemQty = (Int32.Parse(getItemQty) + Int32.Parse(AddList.Model_Cart[i].ItemQty)).ToString();
					CheckItemCart = true;
					break;
				}

			}
			if(CheckItemCart == false)
			{
				Model_AddCartList item = new Model_AddCartList()
				{
					ItemID = getItemID,
					ItemName = getItemName,
					ItemPrice = getItemPrice,
					ItemQty = getItemQty,
				};
				AddList.Model_Cart.Add(item);
			}



			return RedirectToAction("Products", "Home", new { subcatid = getsubcatId });
			//return Content(Request.RouteValues.ToString());
			//return Content("ItemName:" + getItemName +"<br>Item Code:" + getItemID +"<br>Price:"+ getItemPrice+"<br>Qty: "+ getItemQty);
		}
		public IActionResult cart() 
		{
			return View(classCategeoryModels);
		}
		[HttpPost]
		public IActionResult update_cart()
		{
			var product_Id = Request.Form["ID"].ToString();
			var quantity = Request.Form["quantity"].ToString();
			var name = Request.Form["name"].ToString();
            var total = Request.Form["total"].ToString();

			var model = AddList.Model_Cart.FirstOrDefault(a => a.ItemID == product_Id);

            if (model != null)
            {
				model.ItemName = name;
				model.ItemPrice = total;
				model.ItemQty = quantity;
				model.ItemID = product_Id;
            }





            return Content("item ID =>" + product_Id);
		}
		public IActionResult delete_cart(string id) 
		{

			var to_delete_item = AddList.Model_Cart.FindIndex(d => d.ItemID == id);
            if (to_delete_item != null)
            {
				AddList.Model_Cart.RemoveAt(to_delete_item);
            }
            
                  return RedirectToAction("cart", "Home", classCategeoryModels);

        }
		public IActionResult checkout() 
		{
			return Content("Hi");
		}
        public IActionResult Index()
		{
			return View(classCategeoryModels);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult ContactUs()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}