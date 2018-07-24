using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSGeek.Web.DAL;
using SSGeek.Web.Models;
using Microsoft.AspNetCore.Http;
using SSGeek.Web.Extensions;

namespace SSGeek.Web.Controllers
{
    public class StoreController : Controller
    {
		private const string SessionKey = "User_Cart";
		IProductDAL dal;
		public StoreController(IProductDAL dal)
		{
			this.dal = dal;
		}
        public IActionResult Index()
        {
			var products = dal.GetProducts();

            return View(products);
        }

		public IActionResult Details(int id)
		{
			
			Product product = dal.GetProduct(id);

			return View(product);

		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddToCart(int id, int quantity)
		{
			
			var shoppingCart = GetActiveShoppingCart();
			var productToAdd = dal.GetProduct(id);
			;
			shoppingCart.AddToCart(productToAdd, quantity);

			HttpContext.Session.Set(SessionKey, shoppingCart);
			return RedirectToAction("ViewCart", "Store");
		}

		private ShoppingCart GetActiveShoppingCart()
		{
			ShoppingCart cart = HttpContext.Session.Get<ShoppingCart>(SessionKey);

			//see if the user has a cart in session
			if (cart == null)
			{
				cart = new ShoppingCart();
				HttpContext.Session.Set(SessionKey, cart);
			}

			return cart;

		}

		[HttpGet]
		public IActionResult ViewCart()
		{
			//14. in the ViewCart action, retrieve the shopping cart from session, and pass it to the view as a model
			var shoppingCart = GetActiveShoppingCart();
			return View(shoppingCart);
		}
	}
}