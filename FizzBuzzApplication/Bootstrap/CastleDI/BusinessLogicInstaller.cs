using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FizzBuzzApplication.BusinessFacade.Implementation;
using FizzBuzzApplication.BusinessFacade.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FizzBuzzApplication.Bootstrap.CastleDI
{
    public class BusinessLogicInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDivisibleFacade>().ImplementedBy<DivisibleFacade>());
        }
    }
}