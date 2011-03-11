// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.immutable
{

	public class PointBuilder
	{
		private double x;
		private double y = 2;
		
		public virtual PointBuilder Set(Point other)
		{
			SetX(other.X);
			SetY(other.Y);
			return this;
		}
		
		public virtual PointBuilder SetX(double x)
		{
			this.x = x;
			return this;
		}
		
		public virtual PointBuilder SetY(double y)
		{
			this.y = y;
			return this;
		}
		
		public virtual Point Build()
		{
			return new Point(this.x, this.y);
		}
	}
	
}
