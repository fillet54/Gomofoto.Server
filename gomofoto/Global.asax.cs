using FiftyCuatro.Gomofoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace FiftyCuatro.Gomofoto
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            System.Data.Entity.Database.SetInitializer(
                new GomofotoContextInitializer());
            //GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
