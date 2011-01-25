// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.computeProperty
{

	[DataContract]
	[DebuggerDisplay("MyImmutableClass[X={X} Y={Y} Children={Children.Count}items]")]
	public abstract class BaseMyImmutableClass : ICloneable
	{
		[DataMember(Name = "X", Order = 0, IsRequired = false)]
		public readonly double X;
		
		[DataMember(Name = "Y", Order = 1, IsRequired = false)]
		public readonly double Y;
		
		[DataMember(Name = "Children", Order = 5, IsRequired = false)]
		public readonly ReadOnlyCollection<MyClass> Children;
		
		public BaseMyImmutableClass(double x, double y, IEnumerable<MyClass> children)
		{
			X = x;
			Y = y;
			Children = new ReadOnlyCollection<MyClass>(new List<MyClass>(children));
		}
		
		public BaseMyImmutableClass(BaseMyImmutableClass other)
		{
			X = other.X;
			Y = other.Y;
			Children = new ReadOnlyCollection<MyClass>(new List<MyClass>(other.Children));
		}
		
		public virtual MyImmutableClass WithX(double x)
		{
			return new MyImmutableClass(x, Y, Length, Dummy, SquaredLength, Children);
		}
		
		public virtual MyImmutableClass WithY(double y)
		{
			return new MyImmutableClass(X, y, Length, Dummy, SquaredLength, Children);
		}
		
		public double Length
		{
			get {
				return ComputeLength();
			}
		}
		
		protected virtual double ComputeLength()
		{
			return Math.Sqrt(X * X + Y * Y);
		}
		
		public string Dummy
		{
			get {
				return ComputeDummy();
			}
		}
		
		protected abstract string ComputeDummy();
		
		public double SquaredLength
		{
			get {
				return ComputeSquaredLength();
			}
		}
		
		protected abstract double ComputeSquaredLength();
		
		public MyImmutableClass Clone()
		{
			return (MyImmutableClass) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new MyImmutableClass((MyImmutableClass) this);
		}
	}
	
}
