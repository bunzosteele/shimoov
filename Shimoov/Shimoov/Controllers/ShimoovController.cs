using System;
using System.Runtime.Remoting.Messaging;
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
			var locationResult = queryWolfram(location);
			var destinationResult = queryWolfram(destination);
			return Content(locationResult);
		}

		private int salaryCalculation(int oldSalary, int coastOfLivingRatio, int newSalary)
		{
			int adjustedSalary = (oldSalary / coastOfLivingRatio) * newSalary;
			return adjustedSalary;
		}

		private string queryWolfram(string input)
		{
			WolframAlpha wolfram = new WolframAlpha("ARQJPTG-976HAP24AX");

			QueryResult results = wolfram.Query("cost of living index " + input);

			string result = "";
			if (results != null)
			{
				foreach (Pod pod in results.Pods)
				{
					Console.WriteLine(pod.Title);
					if (pod.SubPods != null)
					{
						foreach (SubPod subPod in pod.SubPods)
						{
							result += subPod.Title + " ";
							result += subPod.Plaintext;
						}
					}
				}
			}
			else
			{
				result = "NULL";
			}
			return result;
		}
	}
}
