using System;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace dependencyInjection
{
	public class ClassA
	{
		private readonly IClassB _classB;
		public ClassA(IClassB classB)
		{
			this._classB = classB;
		}

		public int DoubleIt(int a, int b)
        {
			return this._classB.Sum(a,b) * 2 ;
        }

	}
}