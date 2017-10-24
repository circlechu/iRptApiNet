using System.Web;
using System.Web.Http;
using iRpt.Common.Logging;
using iRpt.Common.Security;
using iRpt.Common.TypeMapping;
using iRpt.Web.Common;

namespace iRpt.Web.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterHandlers();
//            new AutoMapperConfigurator().Configure(
//                WebContainerManager.GetAll<IAutoMapperTypeConfigurator>());
        }

        private void RegisterHandlers()
        {
            var logManager = WebContainerManager.Get<ILogManager>();
            var userSession = WebContainerManager.Get<IUserSession>();
        }
    }
}