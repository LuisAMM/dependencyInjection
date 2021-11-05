using System;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace dependencyInjection
{
	public class ClassB : IClassB
	{
		public ClassB()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public int Sum(int a, int b)
		{
			return a + b;
		}
	}
}