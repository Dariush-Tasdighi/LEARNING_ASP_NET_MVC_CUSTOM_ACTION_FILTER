namespace Infrastructure
{
	/// <summary>
	/// Middleware
	/// </summary>
	public class LogAttribute : System.Web.Mvc.ActionFilterAttribute
	{
		/// <summary>
		/// Step (4)
		/// </summary>
		public LogAttribute() : base()
		{
		}

		/// <summary>
		/// Step (7) = گلوگاه
		/// </summary>
		public override void OnActionExecuting
			(System.Web.Mvc.ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);

			string actionName =
				filterContext.ActionDescriptor.ActionName;

			string controllerName =
				filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

			string areaName = null;

			if (filterContext.RouteData.DataTokens["area"] != null)
			{
				areaName =
					filterContext.RouteData.DataTokens["area"].ToString();
			}
		}

		/// <summary>
		/// Step (11)
		/// </summary>
		public override void OnActionExecuted
			(System.Web.Mvc.ActionExecutedContext filterContext)
		{
			base.OnActionExecuted(filterContext);
		}

		/// <summary>
		/// Step (12)
		/// </summary>
		public override void OnResultExecuting
			(System.Web.Mvc.ResultExecutingContext filterContext)
		{
			base.OnResultExecuting(filterContext);
		}

		/// <summary>
		/// Step (16)
		/// </summary>
		public override void OnResultExecuted
			(System.Web.Mvc.ResultExecutedContext filterContext)
		{
			base.OnResultExecuted(filterContext);
		}

		/// <summary>
		/// Step (17)
		/// </summary>
		/// ارسال داده به سمت کلاينت
	}
}
