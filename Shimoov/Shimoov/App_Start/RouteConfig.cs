using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Shimoov
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);

			routes.MapRoute(name: "Experiment", url: "ExperimentId",
				defaults: new {controller = "Home", action = "Experiment", id = UrlParameter.Optional});

			routes.MapRoute(name: "Test", url: "test",
				defaults: new {controller = "TestController", action = "Test", id = UrlParameter.Optional});
		}
	}
}
