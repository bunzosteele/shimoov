using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Shimoov.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return Content("Home");
		}

		public ActionResult Experiment(int experimentId)
		{
			return Content(experimentId.ToString());
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}