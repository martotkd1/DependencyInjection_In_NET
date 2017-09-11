using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Controllers;

namespace WebUI
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(
            System.Web.Routing.RequestContext requestContext, string controllerName)
        {                        
            IController controller = null;
            Type controllerType = Type.GetType(string.Format("WebUI.Controllers.{0}Controller", controllerName));
            switch (controllerName)
            {
                case "Home":                    
                    var sqlProductRepository = new SqlDataAccess.SqlProductRepository();
                    controller = Activator.CreateInstance(controllerType, new[] { sqlProductRepository }) as Controller;
                    break;
                default:
                    controller = Activator.CreateInstance(controllerType) as IController;
                    break;
            }

            return controller;
        }

        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(
            System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            return System.Web.SessionState.SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable dispose = controller as IDisposable;
            if (dispose != null)
            {
                dispose.Dispose();
            }
        }
    }
}