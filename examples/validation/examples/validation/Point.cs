// Automatically generated by Model#
// Remove the above line before editing this file and it won't be changed by Model#

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.validation
{

	[DataContract]
	public class Point : BasePoint
	{
		public Point(double x, double w)
		: base(x, w)
		{
		}
		
		public Point(Point other)
		: base(other)
		{
		}
		
	}
	
}
