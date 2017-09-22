using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;using ex2.Models;

namespace ex2.Controllers
{
    public class BlogController : Controller
    {
        private BlogDbContext db = new BlogDbContext();

        // GET: Blog
        public ActionResult Index()
        {
            var posts = db.Posts.Include(c => c.Comments).ToList();
            return View(posts);
        }
    }
}