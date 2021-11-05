using System;
using Autofac;

namespace dependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ConsoleModule>();
            
            var container = builder.Build();
            var a = container.Resolve<ClassA>();
            var a2 = container.Resolve<ClassA>();
            
            Console.WriteLine($"{a==a2}");
        }
    }
}
