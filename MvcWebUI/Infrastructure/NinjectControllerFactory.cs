using Ninject;
using Northwind.Bll;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninject_Kernel;

        public NinjectControllerFactory()
        {
            _ninject_Kernel = new StandardKernel();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            _ninject_Kernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new EfProductDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninject_Kernel.Get(controllerType);
        }
    }
}