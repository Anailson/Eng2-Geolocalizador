using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Interfaces;
using StructureMap;

namespace Geolocalizador.App_Start
{
    public class AppConfig : DefaultControllerFactory
    {
        public AppConfig()
        {
            ObjectFactory.Initialize(i =>
            {
                i.For<IUnidadeTrabalho>().HttpContextScoped();
                i.For<IRepositorio>().HttpContextScoped();

                i.Scan(s =>
                {
                    s.Assembly("Infraestrutura");
                    s.WithDefaultConventions();
                });

                i.SetAllProperties(s =>
                {
                    s.Matching(p => typeof(IUnidadeTrabalho).IsAssignableFrom(p.PropertyType));
                    s.Matching(p => typeof(IRepositorio).IsAssignableFrom(p.PropertyType));
                });
            });
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            if (requestContext == null || controllerType == null)
            {
                return null;
            }

            return (IController)ObjectFactory.GetInstance(controllerType);
        }

        public static void ReleaseAndDisposeAllHttpScopedObjects()
        {
            ObjectFactory.ReleaseAndDisposeAllHttpScopedObjects();
        }
    }
}