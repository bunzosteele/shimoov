using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shimoov.Controllers
{
	public class TestController : Controller
	{
		public ActionResult Test()
		{
			return Content("TestSuceeded.");
		}
	}
}