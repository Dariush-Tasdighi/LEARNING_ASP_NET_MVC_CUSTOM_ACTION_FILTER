namespace Infrastructure
{
	/// <summary>
	/// Middleware
	/// </summary>
	public class LogAttribute : System.Web.Mvc.ActionFilterAttribute
	{
		//public LogAttribute() : base()
		//{
		//}

		/// <summary>
		/// Step (4)
		/// </summary>
		public LogAttribute(bool ignore = false) : base()
		{
			Ignore = ignore;
		}

		public bool Ignore { get; set; }

		/// <summary>
		/// Step (6) = گلوگاه
		/// </summary>
		public override void OnActionExecuting
			(System.Web.Mvc.ActionExecutingContext filterContext)
		{
			if (Ignore)
			{
				return;
			}

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
		/// Step (8)
		/// </summary>
		public override void OnActionExecuted
			(System.Web.Mvc.ActionExecutedContext filterContext)
		{
			if (Ignore)
			{
				return;
			}

			base.OnActionExecuted(filterContext);
		}

		/// <summary>
		/// Step (9)
		/// </summary>
		public override void OnResultExecuting
			(System.Web.Mvc.ResultExecutingContext filterContext)
		{
			if (Ignore)
			{
				return;
			}

			base.OnResultExecuting(filterContext);
		}

		/// <summary>
		/// Step (11)
		/// </summary>
		public override void OnResultExecuted
			(System.Web.Mvc.ResultExecutedContext filterContext)
		{
			if (Ignore)
			{
				return;
			}

			base.OnResultExecuted(filterContext);
		}

		/// <summary>
		/// Step (12)
		/// </summary>
		/// ارسال داده به سمت کلاينت
	}
}
