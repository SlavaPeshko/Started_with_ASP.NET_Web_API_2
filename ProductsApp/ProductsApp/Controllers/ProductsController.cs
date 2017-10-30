using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
	public class ProductsController : ApiController
	{
		Product[] _products =
		{
			new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
			new Product {Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75m},
			new Product {Id = 2, Name = "Hammer", Category = "Hardware", Price = 16.99M}
		};

		// api/products
		public IEnumerable<Product> GetAllProducts()
		{
			return _products;
		}

		//api/product/id
		public IHttpActionResult GetProduct(int id)
		{
			var product = _products.FirstOrDefault(n => n.Id == id);
			if (product == null)
				return NotFound();
			return Ok(product);
		}
	}
}