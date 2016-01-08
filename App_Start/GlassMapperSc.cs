/*************************************

DO NOT CHANGE THIS FILE - UPDATE GlassMapperScCustom.cs

**************************************/

using System;
using System.Linq;
using Glass.Mapper.Sc.CastleWindsor;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Pipelines;

// WebActivator has been removed. If you wish to continue using WebActivator uncomment the line below
// and delete the Glass.Mapper.Sc.CastleWindsor.config file from the Sitecore Config Include folder.

namespace MvcApplication1.App_Start
{
	public class  GlassMapperSc
	{
		public static DependencyResolver DependencyResolver { get; private set; }

		public void Process(PipelineArgs args){
			GlassMapperSc.Start();
		}

		public static void Start()
		{
			//create the resolver
			DependencyResolver = GlassMapperScCustom.CreateResolver() ?? DependencyResolver.CreateStandardResolver();

			//install the custom services
			GlassMapperScCustom.CastleConfig(DependencyResolver.Container);

			//create a context
			var context = Glass.Mapper.Context.Create(DependencyResolver);
			context.Load(      
				GlassMapperScCustom.GlassLoaders()        				
				);

			GlassMapperScCustom.PostLoad();
		}
	}
}