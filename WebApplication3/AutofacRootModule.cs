using Autofac;
using Autofac.Core;
using WebApplication3.Controllers;
using WebApplication3.Models;
using Autofac.Features.AttributeFilters;
using Autofac.Integration.Mvc;

namespace WebApplication3
{
    internal class AutofacRootModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CreateCounter>().As<ISinglton>().SingleInstance();
            builder.RegisterType<CreateCounter>().As<IScoped>().InstancePerLifetimeScope();
            builder.RegisterType<CreateCounter>().As<ITransient>().InstancePerDependency();
            
            builder.RegisterType<EmailSender>().Keyed<ISender>("senderEmail");
            builder.RegisterType<SmsSender>().Keyed<ISender>("senderSms");
            builder.RegisterType<SenterService>().WithAttributeFiltering();

            var instance = new TimeService();
            builder.RegisterInstance(instance);
        }
    }
}