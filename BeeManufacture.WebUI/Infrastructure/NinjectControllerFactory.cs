﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using BeeManufacture.Domain.Abstract;
using BeeManufacture.Domain.Concrete;
using Moq;

namespace BeeManufacture.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {    
            ninjectKernel.Bind<IManufactureRepository>().To<EFManufactureRepository>();         
        }
    }
}