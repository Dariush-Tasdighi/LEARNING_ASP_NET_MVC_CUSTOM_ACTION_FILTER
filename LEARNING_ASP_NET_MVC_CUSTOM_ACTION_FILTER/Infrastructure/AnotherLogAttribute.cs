namespace Infrastructure
{
	public class AnotherLogAttribute : System.Web.Mvc.ActionFilterAttribute
	{
		/// <summary>
		/// Step (5)
		/// </summary>
		public AnotherLogAttribute() : base()
		{
		}

		/// <summary>
		/// Step (8)
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
		}

		/// <summary>
		/// Step (10)
		/// </summary>
		public override void OnActionExecuted
			(System.Web.Mvc.ActionExecutedContext filterContext)
		{
			base.OnActionExecuted(filterContext);
		}

		/// <summary>
		/// Step (13)
		/// </summary>
		public override void OnResultExecuting
			(System.Web.Mvc.ResultExecutingContext filterContext)
		{
			base.OnResultExecuting(filterContext);
		}

		/// <summary>
		/// Step (15)
		/// </summary>
		public override void OnResultExecuted
			(System.Web.Mvc.ResultExecutedContext filterContext)
		{
			base.OnResultExecuted(filterContext);
		}
	}
}
