namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER.Controllers
{
	//[Infrastructure.Log(Ignore = true)]
	public class HomeController : System.Web.Mvc.Controller
	{
		/// <summary>
		/// Step (5)
		/// </summary>
		public HomeController() : base()
		{
		}

		/// <summary>
		/// Step (7)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		/// <summary>
		/// Step (7)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		[Infrastructure.Log(Ignore = true)]
		public System.Web.Mvc.ViewResult SomeAction()
		{
			return (View());
		}
	}
}
