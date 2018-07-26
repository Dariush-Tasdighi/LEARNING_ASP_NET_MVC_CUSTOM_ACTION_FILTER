namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER.Controllers
{
	public class HomeController : System.Web.Mvc.Controller
	{
		/// <summary>
		/// Step (1)
		/// </summary>
		public HomeController() : base()
		{
		}

		/// <summary>
		/// Step (2)
		/// </summary>
		[System.Web.Mvc.HttpGet]
		//[System.Web.Mvc.HttpGetAttribute]
		public System.Web.Mvc.ViewResult Index()
		{
			return (View());
		}

		/// <summary>
		/// Step (4)
		/// </summary>
		[Infrastructure.Log]
		//[Infrastructure.Log()]
		//[Infrastructure.LogAttribute]
		//[Infrastructure.LogAttribute()]
		[System.Web.Mvc.HttpGet]
		public System.Web.Mvc.ViewResult SomeAction()
		{
			return (View());
		}
	}
}
