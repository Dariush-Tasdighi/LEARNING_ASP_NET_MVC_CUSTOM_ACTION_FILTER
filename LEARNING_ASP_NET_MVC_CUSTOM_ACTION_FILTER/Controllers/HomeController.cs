namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER.Controllers
{
	public class HomeController : System.Web.Mvc.Controller
	{
		/// <summary>
		/// Step (6)
		/// </summary>
		public HomeController() : base()
		{
		}

		/// <summary>
		/// Step (9)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult Index()
		{
			return View();
		}

		/// <summary>
		/// Step (9)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult SomeAction()
		{
			return View();
		}
	}
}
