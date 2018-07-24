using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using SSGeek.Web.Models;

namespace SSGeek.Web.DAL
{
    public class ForumPostSqlDAL 
    {
		private readonly string connectionString;

		public ForumPostSqlDAL(string connectionString)
		{
			this.connectionString = connectionString;
		}

        public List<ForumPost> GetAllPosts()
        {
            List<ForumPost> output = new List<ForumPost>();
			try
			{
				//create a new connection object
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					//open the connection
					conn.Open();

					string sql = $"SELECT * FROM forum_post ORDER BY id DESC";
					SqlCommand cmd = new SqlCommand(sql, conn);

					//execute the command 
					SqlDataReader reader = cmd.ExecuteReader();

					//Loop through each row 
					while (reader.Read())
					{
						//create the forum
						ForumPost forum = new ForumPost();
						forum.ID = Convert.ToInt32(reader["id"]);
						forum.Username = Convert.ToString(reader["username"]);
						forum.Subject = Convert.ToString(reader["subject"]);
						forum.Message = Convert.ToString(reader["message"]);
						forum.PostDate = Convert.ToDateTime(reader["post_date"]);

						output.Add(forum);

					}
				}
			}
			catch(SqlException)
			{
				throw;
			}

			return output;
        }

        public bool SaveNewPost(ForumPost post)
        {
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					string sql = $"INSERT INTO forum_post(username, subject, message, post_date) VALUES (@username, @subject, @message, @post_date)";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@username", post.Username);
					cmd.Parameters.AddWithValue("@subject", post.Subject);
					cmd.Parameters.AddWithValue("@message", post.Message);
					cmd.Parameters.AddWithValue("@post_date", DateTime.Now);
					

					cmd.ExecuteNonQuery();
				}
			}
			catch (SqlException)
			{
				return false;
			}

			return true;
        }
    }
}
