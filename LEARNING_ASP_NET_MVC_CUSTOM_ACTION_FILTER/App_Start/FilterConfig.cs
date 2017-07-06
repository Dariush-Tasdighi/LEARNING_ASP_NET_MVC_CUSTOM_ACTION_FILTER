namespace LEARNING_ASP_NET_MVC_CUSTOM_ACTION_FILTER
{
	public static class FilterConfig
	{
		/// <summary>
		/// Step (2)
		/// </summary>
		static FilterConfig()
		{
		}

		/// <summary>
		/// Step (3)
		/// </summary>
		public static void RegisterGlobalFilters
			(System.Web.Mvc.GlobalFilterCollection filters)
		{
			// قانون دور در دور نزدیک در نزدیک
			filters.Add(new Infrastructure.LogAttribute());
			filters.Add(new Infrastructure.AnotherLogAttribute());

			filters.Add(new System.Web.Mvc.HandleErrorAttribute());
		}
	}
}
