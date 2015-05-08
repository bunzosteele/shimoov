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
		public ActionResult Test(int input)
		{
			return Content(input.ToString());
		}

		[HttpGet]
		public ActionResult Query(string location, int salary, string destination)
		{
			throw new NotImplementedException();
		}
	}
}
