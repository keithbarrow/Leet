using Leet.Api.Unity;
using Leet.Data.Model;
using Leet.Data.Model.Interfaces;
using Leet.Data.Repositories;
using Leet.Data.Repositories.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Leet.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
			var container = new UnityContainer();
			RegisterDependencies(container);
			config.DependencyResolver = new UnityResolver(container);
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

		private static void RegisterDependencies(UnityContainer container)
		{
			container.RegisterType<IRepository<ICourse>, CourseRepository>(new HierarchicalLifetimeManager());
		}
    }
}
