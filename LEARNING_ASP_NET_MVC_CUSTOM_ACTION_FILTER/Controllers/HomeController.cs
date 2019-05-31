namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER.Controllers
{
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
			return View();
		}

		/// <summary>
		/// Step (7)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		//[System.Web.Mvc.Authorize]
		public System.Web.Mvc.ViewResult SomeSecuredAction()
		{
			return View();
		}

		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult AccessDenied()
		{
			return View();
		}
	}
}
