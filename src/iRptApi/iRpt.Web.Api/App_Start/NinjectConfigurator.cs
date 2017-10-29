using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using iRpt.Common.Adapters;
using iRpt.Common.Adapters.Impls;
using iRpt.Common.Logging;
using iRpt.Common.Security;
using iRpt.Common.TypeMapping;
using iRpt.Data.Dal.Mapping;
using iRpt.Data.Dal.QueryProcessors;
using iRpt.Data.QueryProcessors;
using iRpt.Web.Api.AutoMappingConfiguration;
using iRpt.Web.Api.MaintenanceProcessing;
using iRpt.Web.Api.MaintenanceProcessing.Impl;
using iRpt.Web.Api.Models;
using iRpt.Web.Common;
using iRpt.Web.Common.Security;
using log4net.Config;
using NHibernate;
using NHibernate.Context;
using Ninject;
using Ninject.Activation;
using Ninject.Web.Common;

namespace iRpt.Web.Api
{
    public class NinjectConfigurator
    {
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }

        private void AddBindings(IKernel container)
        {
            ConfigureLog4net(container);
            ConfigureUserSession(container);
            ConfigureNHibernate(container);
            ConfigureAutoMapper(container);

            container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
            container.Bind<IClientQueryProcessor>().To<ClientQueryProcessor>().InSingletonScope();
            container.Bind<IFundQueryProcessor>().To<FundQueryProcessor>().InSingletonScope();
            container.Bind<IClientMaintenanceProcessor>().To<ClientMaintenanceProcessor>().InSingletonScope();
        }

        private void ConfigureLog4net(IKernel container)
        {
            XmlConfigurator.Configure();
            var logManager = new LogManagerAdapter();
            container.Bind<ILogManager>().ToConstant(logManager);
        }

        private void ConfigureUserSession(IKernel container)
        {
            var userSession = new UserSession();
            container.Bind<IUserSession>().ToConstant(userSession).InSingletonScope();
            container.Bind<IWebUserSession>().ToConstant(userSession).InSingletonScope();
        }

        private void ConfigureNHibernate(IKernel container)
        {
            var sessionFactory = Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008.ConnectionString(
                        c => c.FromConnectionStringWithKey("iRptApi")))
                .CurrentSessionContext("web")
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ClientMap>())
                .BuildSessionFactory();
            container.Bind<ISessionFactory>().ToConstant(sessionFactory);
            container.Bind<ISession>().ToMethod(CreateSession).InRequestScope();
            container.Bind<IActionTransactionHelper>().To<ActionTransactionHelper>().InRequestScope();
        }

        private ISession CreateSession(IContext context)
        {
            var sessionFactory = context.Kernel.Get<ISessionFactory>();
            if (!CurrentSessionContext.HasBind(sessionFactory))
            {
                var session = sessionFactory.OpenSession();
                CurrentSessionContext.Bind(session);
            }
            return sessionFactory.GetCurrentSession();
        }

        private void ConfigureAutoMapper(IKernel container)
        {
            container.Bind<IAutoMapper>().To<AutoMapperAdapter>().InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>().To<ClientModelConfiguration>().InSingletonScope();
            container.Bind<IAutoMapperTypeConfigurator>().To<ClientModelConfiguration>().InSingletonScope();
        }
    }
}