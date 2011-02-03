using org.pescuma.ModelSharp.Lib;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.doc
{

	[DataContract]
	public class Point : BasePoint
	{
		public Point()
		: base()
		{
		}
		
		public Point(Point other)
		: base(other)
		{
		}
		
		protected override double ComputeLen()
		{
			// TODO
			throw new NotImplementedException();
		}
		
	}
	
}