// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.computeProperty
{

	public class MyImmutableClassBuilder
	{
		private double x;
		private double y = 2;
		private readonly List<MyClass> children = new List<MyClass>();
		
		public virtual MyImmutableClassBuilder Set(MyImmutableClass other)
		{
			SetX(other.X);
			SetY(other.Y);
			ClearChildren();
			AddToChildren(other.Children);
			return this;
		}
		
		public virtual MyImmutableClassBuilder SetX(double x)
		{
			this.x = x;
			return this;
		}
		
		public virtual MyImmutableClassBuilder SetY(double y)
		{
			this.y = y;
			return this;
		}
		
		public virtual MyImmutableClassBuilder ClearChildren()
		{
			this.children.Clear();
			return this;
		}
		public virtual MyImmutableClassBuilder AddToChildren(MyClass children)
		{
			this.children.Add(children);
			return this;
		}
		public virtual MyImmutableClassBuilder AddToChildren(IEnumerable<MyClass> children)
		{
			this.children.AddRange(children);
			return this;
		}
		
		public virtual MyImmutableClass Build()
		{
			return new MyImmutableClass(this.x, this.y, this.children);
		}
	}
	
}
