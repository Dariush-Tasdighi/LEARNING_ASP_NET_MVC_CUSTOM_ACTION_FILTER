namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER.Controllers
{
	[Infrastructure.Log]
	public class HomeController : System.Web.Mvc.Controller
	{
		/// <summary>
		/// Step (1)
		/// </summary>
		public HomeController() : base()
		{
		}

		/// <summary>
		/// Step (4)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		/// <summary>
		/// Step (4)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult SomeAction()
		{
			return (View());
		}
	}
}
