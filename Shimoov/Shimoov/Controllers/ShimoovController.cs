using System;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using Shimoov.Models;

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
            var dto = new RequestDTO() {
                Location = location,
                Salary = salary,
                Destination = destination
            };
			return Content("133700");
		}

        private int salaryCalculation(int oldSalary, int coastOfLivingRatio, int newSalary)
        {
            int adjustedSalary = (oldSalary / coastOfLivingRatio) * newSalary;
            return adjustedSalary;
        }
	}
}
