namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public MvcApplication() : base()
		{
		}

		/// <summary>
		/// Step (1)
		/// </summary>
		protected void Application_Start()
		{
			System.Web.Mvc.AreaRegistration.RegisterAllAreas();

			FilterConfig.RegisterGlobalFilters(System.Web.Mvc.GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
		}
	}
}
