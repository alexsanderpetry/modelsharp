// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.deepCopy
{

	public class ImmutablePersonBuilder
	{
		private readonly List<ImmutableAddress> _homeAddressCol = new List<ImmutableAddress>();
		private readonly List<ImmutableAddress> _workAddressCol = new List<ImmutableAddress>();
		private readonly List<string> _stringCol = new List<string>();
		private readonly List<string> _stringCol2 = new List<string>();
		private readonly List<double> _doubleCol = new List<double>();
		private readonly List<double> _doubleCol2 = new List<double>();
		private Address _homeAddressProp;
		private Address _workAddressProp;
		
		public virtual ImmutablePersonBuilder Set(ImmutablePerson other)
		{
			ClearHomeAddressCol();
			AddToHomeAddressCol(other.HomeAddressCol);
			ClearWorkAddressCol();
			AddToWorkAddressCol(other.WorkAddressCol);
			ClearStringCol();
			AddToStringCol(other.StringCol);
			ClearStringCol2();
			AddToStringCol2(other.StringCol2);
			ClearDoubleCol();
			AddToDoubleCol(other.DoubleCol);
			ClearDoubleCol2();
			AddToDoubleCol2(other.DoubleCol2);
			SetHomeAddressProp(other.HomeAddressProp);
			SetWorkAddressProp(other.WorkAddressProp);
			return this;
		}
		
		public virtual ImmutablePersonBuilder ClearHomeAddressCol()
		{
			_homeAddressCol.Clear();
			return this;
		}
		public virtual ImmutablePersonBuilder AddToHomeAddressCol(ImmutableAddress homeAddressCol)
		{
			_homeAddressCol.Add(homeAddressCol);
			return this;
		}
		public virtual ImmutablePersonBuilder AddToHomeAddressCol(IEnumerable<ImmutableAddress> homeAddressCol)
		{
			_homeAddressCol.AddRange(homeAddressCol);
			return this;
		}
		
		public virtual ImmutablePersonBuilder ClearWorkAddressCol()
		{
			_workAddressCol.Clear();
			return this;
		}
		public virtual ImmutablePersonBuilder AddToWorkAddressCol(ImmutableAddress workAddressCol)
		{
			_workAddressCol.Add(workAddressCol);
			return this;
		}
		public virtual ImmutablePersonBuilder AddToWorkAddressCol(IEnumerable<ImmutableAddress> workAddressCol)
		{
			_workAddressCol.AddRange(workAddressCol);
			return this;
		}
		
		public virtual ImmutablePersonBuilder ClearStringCol()
		{
			_stringCol.Clear();
			return this;
		}
		public virtual ImmutablePersonBuilder AddToStringCol(string stringCol)
		{
			_stringCol.Add(stringCol);
			return this;
		}
		public virtual ImmutablePersonBuilder AddToStringCol(IEnumerable<string> stringCol)
		{
			_stringCol.AddRange(stringCol);
			return this;
		}
		
		public virtual ImmutablePersonBuilder ClearStringCol2()
		{
			_stringCol2.Clear();
			return this;
		}
		public virtual ImmutablePersonBuilder AddToStringCol2(string stringCol2)
		{
			_stringCol2.Add(stringCol2);
			return this;
		}
		public virtual ImmutablePersonBuilder AddToStringCol2(IEnumerable<string> stringCol2)
		{
			_stringCol2.AddRange(stringCol2);
			return this;
		}
		
		public virtual ImmutablePersonBuilder ClearDoubleCol()
		{
			_doubleCol.Clear();
			return this;
		}
		public virtual ImmutablePersonBuilder AddToDoubleCol(double doubleCol)
		{
			_doubleCol.Add(doubleCol);
			return this;
		}
		public virtual ImmutablePersonBuilder AddToDoubleCol(IEnumerable<double> doubleCol)
		{
			_doubleCol.AddRange(doubleCol);
			return this;
		}
		
		public virtual ImmutablePersonBuilder ClearDoubleCol2()
		{
			_doubleCol2.Clear();
			return this;
		}
		public virtual ImmutablePersonBuilder AddToDoubleCol2(double doubleCol2)
		{
			_doubleCol2.Add(doubleCol2);
			return this;
		}
		public virtual ImmutablePersonBuilder AddToDoubleCol2(IEnumerable<double> doubleCol2)
		{
			_doubleCol2.AddRange(doubleCol2);
			return this;
		}
		
		public virtual ImmutablePersonBuilder SetHomeAddressProp(Address homeAddressProp)
		{
			_homeAddressProp = homeAddressProp;
			return this;
		}
		
		public virtual ImmutablePersonBuilder SetWorkAddressProp(Address workAddressProp)
		{
			_workAddressProp = workAddressProp;
			return this;
		}
		
		public virtual ImmutablePerson Build()
		{
			return new ImmutablePerson(_homeAddressCol, _workAddressCol, _stringCol, _stringCol2, _doubleCol, _doubleCol2, _homeAddressProp, _workAddressProp);
		}
	}
	
}
