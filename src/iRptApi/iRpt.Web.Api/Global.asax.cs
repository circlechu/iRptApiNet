using System;
using System.Web;
using System.Web.Http;
using iRpt.Common.Logging;
using iRpt.Common.Security;
using iRpt.Common.TypeMapping;
using iRpt.Web.Common;
using log4net;

namespace iRpt.Web.Api
{
    public class WebApiApplication : HttpApplication
    {
        private static readonly ILog _log = WebContainerManager.Get<ILogManager>().GetLog(typeof(WebApiApplication));
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterHandlers();
            try
            {
                new AutoMapperConfigurator().Configure(WebContainerManager.GetAll<IAutoMapperTypeConfigurator>());
            }
            catch (Exception e)
            {
                _log.ErrorFormat("Application_Start:{0}",e.Message);
            }
        }

        private void RegisterHandlers()
        {
            var logManager = WebContainerManager.Get<ILogManager>();
            var userSession = WebContainerManager.Get<IUserSession>();
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();

            if (exception != null)
            {
                _log.Error("Unhandled exception.", exception);
            }
        }

    }
}