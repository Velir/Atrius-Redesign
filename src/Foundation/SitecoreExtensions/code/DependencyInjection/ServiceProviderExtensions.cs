using System;

namespace Thread.Foundation.SitecoreExtensions.DependencyInjection
{
	public static class ServiceProviderExtensions
	{
		public static T GetService<T>(this IServiceProvider serviceProvider) where T : class
		{
			return serviceProvider.GetService(typeof(T)) as T;
		}
	}
}
