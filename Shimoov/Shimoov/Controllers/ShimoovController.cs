using System;
using System.Web.Mvc;

namespace Shimoov.Controllers
{
	public sealed class ShimoovController : Controller
	{
		public ShimoovController()
		{
		}

		[HttpGet]
		public ActionResult Test(int id)
		{
			return Content(id.ToString());
		}

		[HttpGet]
		public ActionResult Query(string location, int salary, string destination)
		{
			return Content("Locaiton:" + location + "Salary:" + salary + "Destination" + destination);
		}
	}
}
