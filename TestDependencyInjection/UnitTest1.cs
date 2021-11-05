using Autofac;
using dependencyInjection;
using Moq;
using NUnit.Framework;
using System;
using Shouldly;

namespace TestDependencyInjection
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 2, 6)]
        [TestCase(3, 2, 10)]
        [TestCase(4, 5, 18)]
        [TestCase(1, 5, 12)]
        [TestCase(12, 6, 36)]
        public void Test1(int a, int b, int expectedValue)
        {
            var classB = new Mock<IClassB>();
            classB.Setup(p => p.Sum(a, b)).Returns(a + b);

            var builder = new ContainerBuilder();
            builder.RegisterModule<ConsoleModule>();
            builder.RegisterInstance<IClassB>(classB.Object);
            var container = builder.Build();

            var classA = container.Resolve<ClassA>();

            classA.DoubleIt(a, b).ShouldBeEquivalentTo(expectedValue);

            classB.VerifyAll();

        }
    }
}