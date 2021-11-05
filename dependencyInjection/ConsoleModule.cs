using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyInjection
{
    class ConsoleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ClassB>().As<IClassB>();
            builder.RegisterType<ClassA>().AsSelf().SingleInstance();
        }
    }
}
