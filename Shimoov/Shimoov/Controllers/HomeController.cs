using System.Web.Mvc;

namespace Shimoov.Controllers
{
	public sealed class HomeController : Controller
	{
		public HomeController()
		{
		}

		public ActionResult Index()
		{
			return Content("This is the root of the Shimoov service.");
		}
	}
}
