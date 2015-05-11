using System.Linq;
using System.Web.Mvc;
using WolframAlphaNET;
using WolframAlphaNET.Objects;

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
			var initialIndex = QueryWolfram(location);
			var finalIndex = QueryWolfram(destination);
			float parsedInitialIndex;
			float parsedFinalIndex;
			// String (Data not Available) is returned when data is unavailable from wolfram. Otherwise, a string representation of a float is returned.
			if (!float.TryParse(initialIndex, out parsedInitialIndex) || !float.TryParse(finalIndex, out parsedFinalIndex))
				return Content("Service Unavailable");
			return Content(SalaryCalculation(salary, parsedInitialIndex, parsedFinalIndex).ToString());
		}

		private float SalaryCalculation(int oldSalary, float oldRatio, float newRatio)
		{
			float adjustedSalary = (oldSalary / oldRatio) * newRatio;
			return adjustedSalary;
		}

		private string QueryWolfram(string input)
		{
			WolframAlpha wolfram = new WolframAlpha("RQJPTG-976HAP24AX");
			QueryResult results = wolfram.Query("cost of living index " + input);

			return results != null ? results.Pods.ToList().Last().SubPods.ToList().Last().Plaintext : "Data not Available";
		}
	}
}
