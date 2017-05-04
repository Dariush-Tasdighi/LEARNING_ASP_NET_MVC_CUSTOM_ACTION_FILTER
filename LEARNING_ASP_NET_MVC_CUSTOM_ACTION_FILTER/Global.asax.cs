namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public MvcApplication() : base()
		{
		}

		protected void Application_Start()
		{
			System.Web.Mvc.AreaRegistration.RegisterAllAreas();

			RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
		}
	}
}
