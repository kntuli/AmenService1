using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace AmenService1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add(new ServiceRoute("", new WebServiceHostFactory(), typeof(Service)));
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //var context = HttpContext.Current;
            //var response = context.Response;

            //response.AddHeader("Access-Control-Allow-Origin", "*");
            //response.AddHeader("Access-Control-Allow-Methods", "GET,PUT,POST,DELETE,TRACE,HEAD,OPTIONS");
            //response.AddHeader("Access-Control-Allow-Headers", "Accept,Accesstoken,Authorization,Cache-Control,Pragma,Content-Type,Origin");

            //response.AddHeader("Access-Control-Allow-Credentials", "true");
            //response.AddHeader("Access-Control-Allow-Headers", "content-type, if-none-match");
            //response.AddHeader("Access-Control-Allow-Methods", "POST,GET,OPTIONS");
            //response.AddHeader("Access-Control-Allow-Origin", "*");
            //response.AddHeader("Access-Control-Max-Age", "3600");
            
            
            //response.AddHeader("Access-Control-Allow-Credentials", "true");
            //response.AddHeader("Access-Control-Max-Age", "1728000");
            //response.AddHeader("X-Frame-Options", "ALLOW-FROM *");

            //if (context.Request.HttpMethod == "OPTIONS")
            //{
            //    response.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
            //    response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            //    response.AddHeader("Access-Control-Max-Age", "1728000");
            //    response.End();
            //}
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}