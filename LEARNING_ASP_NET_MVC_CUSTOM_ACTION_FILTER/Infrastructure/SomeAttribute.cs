namespace Infrastructure
{
	public class SomeAttribute : System.Web.Mvc.ActionFilterAttribute
	{
		public SomeAttribute() : base()
		{
		}

		public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
		{
			base.OnActionExecuting(filterContext);
		}

		public override void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext)
		{
			base.OnActionExecuted(filterContext);
		}

		public override void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext)
		{
			base.OnResultExecuting(filterContext);
		}

		public override void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext)
		{
			base.OnResultExecuted(filterContext);
		}
	}
}
