using SSGeek.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SSGeek.Web.DAL
{
	public class ProductSqlDAL : IProductDAL
	{
		private readonly string connectionString;

		public ProductSqlDAL(string connectionString)
		{
			this.connectionString = connectionString;
		}

		/// <summary>
		/// Gets a single product
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Product GetProduct(int id)
		{
			return GetProducts().FirstOrDefault(p => p.ID == id);
		}

		/// <summary>
		/// Get ALL products
		/// </summary>
		/// <returns></returns>
		public IList<Product> GetProducts()
		{
			IList<Product> output = new List<Product>();
			try
			{
				//create a new connection object
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					//open the connection
					conn.Open();

					string sql = $"SELECT * FROM products";
					SqlCommand cmd = new SqlCommand(sql, conn);

					//execute the command
					SqlDataReader reader = cmd.ExecuteReader();

					//Loop through each row
					while (reader.Read())
					{

						Product pro = new Product();
						pro.ID = Convert.ToInt32(reader["product_id"]);
						pro.Name = Convert.ToString(reader["name"]);
						pro.Description = Convert.ToString(reader["description"]);
						pro.Price = Convert.ToInt32(reader["price"]);
						pro.ImageName = Convert.ToString(reader["image_name"]);

						output.Add(pro);

					}
				}
			}
			catch (SqlException)
			{
				throw;
			}

			return output;
		}
	}

	


}

			
