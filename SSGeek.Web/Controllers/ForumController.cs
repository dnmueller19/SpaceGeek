using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SSGeek.Web.DAL;
using SSGeek.Web.Models;

namespace SSGeek.Web.Controllers
{
    public class ForumController : Controller
    {
		ForumPostSqlDAL dal = new ForumPostSqlDAL(@"Data Source=.\sqlexpress;Initial Catalog=SSGeek;Integrated Security=True");

        public IActionResult Index()
        {
			var posts = dal.GetAllPosts();

            return View(posts);
        }

		[HttpGet]
		public IActionResult NewPost()
		{
			return View();
		}

		[HttpPost]
		public IActionResult NewPost(ForumPost post)
		{
			if (ModelState.IsValid)
			{
				dal.SaveNewPost(post);
				TempData["Show_Message"] = true;
				return RedirectToAction("index");
			}
			return RedirectToAction("index", "forum");
		}
    }
}