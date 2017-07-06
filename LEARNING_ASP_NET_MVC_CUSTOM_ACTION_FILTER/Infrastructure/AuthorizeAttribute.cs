namespace Infrastructure
{
	/// <summary>
	/// Middleware
	/// </summary>
	public class AuthorizeAttribute : System.Web.Mvc.ActionFilterAttribute
	{
		/// <summary>
		/// Step (4)
		/// </summary>
		public AuthorizeAttribute() : base()
		{
		}

		/// <summary>
		/// Step (6) = گلوگاه
		/// </summary>
		public override void OnActionExecuting
			(System.Web.Mvc.ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);

			string strActionName =
				filterContext.ActionDescriptor.ActionName;

			string strControllerName =
				filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

			string strAreaName = null;

			if (filterContext.RouteData.DataTokens["area"] != null)
			{
				strAreaName =
					filterContext.RouteData.DataTokens["area"].ToString();
			}

			if ((string.Compare(strControllerName, "Home", ignoreCase: true) == 0) &&
				(string.Compare(strActionName, "SomeSecuredAction", ignoreCase: true) == 0))
			{
				filterContext.Result =
					new System.Web.Mvc.RedirectToRouteResult(
					new System.Web.Routing.RouteValueDictionary
					{
						{ "area", string.Empty },
						{ "controller", "Home" },
						{ "action", "AccessDenied" }
					});
			}
		}

		/// <summary>
		/// Step (8)
		/// </summary>
		public override void OnActionExecuted
			(System.Web.Mvc.ActionExecutedContext filterContext)
		{
			base.OnActionExecuted(filterContext);
		}

		/// <summary>
		/// Step (9)
		/// </summary>
		public override void OnResultExecuting
			(System.Web.Mvc.ResultExecutingContext filterContext)
		{
			base.OnResultExecuting(filterContext);
		}

		/// <summary>
		/// Step (11)
		/// </summary>
		public override void OnResultExecuted
			(System.Web.Mvc.ResultExecutedContext filterContext)
		{
			base.OnResultExecuted(filterContext);
		}

		/// <summary>
		/// Step (12)
		/// </summary>
		/// ارسال داده به سمت کلاينت
	}
}
