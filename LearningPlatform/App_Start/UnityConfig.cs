using LearningPlatformData;
using LearningPlatformData.DBML;
using LearningPlatformData.Repositories;
using PlatformServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;


namespace LearningPlatform.App_Start
{
    namespace LearningPlatformData
    {
        public static class UnityConfig
        {
            private static readonly UnityContainer _container = new UnityContainer();

            public static IUnityContainer Container => _container;

            public static void RegisterComponents()
            {
                // Register LINQ to SQL DataContext
                _container.RegisterType<LearningDataClassesDataContext>(new PerRequestLifetimeManager());

                // Register Repositories
                _container.RegisterType<ICourseRepository, CourseRepository>();
                _container.RegisterType<ITopicRepository, TopicRepository>();
                _container.RegisterType<IContentRepository, ContentRepository>();
                _container.RegisterType<IMediaRepository, MediaRepository>();

                // Register Services
                _container.RegisterType<ICourseService, CourseService>();
                _container.RegisterType<ITutorialService, TutorialService>();

                DependencyResolver.SetResolver(new UnityDependencyResolver(_container));
            }
        }
    }
}