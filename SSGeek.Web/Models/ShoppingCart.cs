using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSGeek.Web.Models
{  //create a shopping cart class that holds shopping cart items (product, quanity)
	public class ShoppingCart
    {
		public IList<ShoppingCartItem> Items { get; } = new List<ShoppingCartItem>();

		//bool method for the adding to cart
		public bool AddToCart(Product p, int quantity)
		{
			//find item that represents the product if it exists
			var existingItem = Items.FirstOrDefault(item => item.Product.ID == p.ID);

			//if item doesn't exist then add to cart
			if (existingItem == null)
			{
				existingItem = new ShoppingCartItem() { Product = p, Quantity = 0};
				Items.Add(existingItem);
			}
			//update the item's quantity
			existingItem.Quantity += quantity;

			return true;
		}

		public decimal GrandTotal
		{
			get
			{
				//using lambda expressions
				return Items.Sum(item => item.SubTotal);
			}
		}

	}
}
