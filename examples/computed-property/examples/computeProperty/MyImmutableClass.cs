// Automatically generated by Model#
// Remove the above line before editing this file and it won't be changed by Model#

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.computeProperty
{

	[DataContract(Name = "MyImmutableClass")]
	public class MyImmutableClass : BaseMyImmutableClass
	{
		public MyImmutableClass(double x, double y, IEnumerable<MyClass> children)
		: base(x, y, children)
		{
		}
		
		public MyImmutableClass(MyImmutableClass other)
		: base(other)
		{
		}
		
		protected override string ComputeDummy()
		{
			// TODO
			throw new NotImplementedException();
		}
		
		protected override double ComputeSquaredLength()
		{
			// TODO
			throw new NotImplementedException();
		}
		
		protected override double ComputeSquaredLengthCached()
		{
			// TODO
			throw new NotImplementedException();
		}
		
	}
	
}
