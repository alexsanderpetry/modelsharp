//----------------------
// <auto-generated>
//     Automatically generated by Model#
// </auto-generated>
//----------------------
// DO NOT EDIT THIS FILE

using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.deepCopy
{

	[DataContract(Name = "ImmutablePerson")]
	[DebuggerDisplay("ImmutablePerson[HomeAddressCol={HomeAddressCol.Count}items WorkAddressCol={WorkAddressCol.Count}items StringCol={StringCol.Count}items StringCol2={StringCol2.Count}items DoubleCol={DoubleCol.Count}items DoubleCol2={DoubleCol2.Count}items HomeAddressProp={HomeAddressProp} WorkAddressProp={WorkAddressProp}]")]
	[GeneratedCode("Model#", "0.2.0.0")]
	public abstract class BaseImmutablePerson : ICloneable
	{
		[DataMember(Name = "HomeAddressCol", Order = 0, IsRequired = false)]
		public readonly ReadOnlyCollection<ImmutableAddress> HomeAddressCol;
		
		[DataMember(Name = "WorkAddressCol", Order = 1, IsRequired = false)]
		public readonly ReadOnlyCollection<ImmutableAddress> WorkAddressCol;
		
		[DataMember(Name = "StringCol", Order = 2, IsRequired = false)]
		public readonly ReadOnlyCollection<string> StringCol;
		
		[DataMember(Name = "StringCol2", Order = 3, IsRequired = false)]
		public readonly ReadOnlyCollection<string> StringCol2;
		
		[DataMember(Name = "DoubleCol", Order = 4, IsRequired = false)]
		public readonly ReadOnlyCollection<double> DoubleCol;
		
		[DataMember(Name = "DoubleCol2", Order = 5, IsRequired = false)]
		public readonly ReadOnlyCollection<double> DoubleCol2;
		
		[DataMember(Name = "HomeAddressProp", Order = 6, IsRequired = false)]
		public readonly Address HomeAddressProp;
		
		[DataMember(Name = "WorkAddressProp", Order = 7, IsRequired = false)]
		public readonly Address WorkAddressProp;
		
		protected BaseImmutablePerson(IEnumerable<ImmutableAddress> homeAddressCol, IEnumerable<ImmutableAddress> workAddressCol, IEnumerable<string> stringCol, IEnumerable<string> stringCol2, IEnumerable<double> doubleCol, IEnumerable<double> doubleCol2, Address homeAddressProp, Address workAddressProp)
		{
			HomeAddressCol = new ReadOnlyCollection<ImmutableAddress>(new List<ImmutableAddress>(homeAddressCol));
			WorkAddressCol = new ReadOnlyCollection<ImmutableAddress>(new List<ImmutableAddress>(workAddressCol));
			StringCol = new ReadOnlyCollection<string>(new List<string>(stringCol));
			StringCol2 = new ReadOnlyCollection<string>(new List<string>(stringCol2));
			DoubleCol = new ReadOnlyCollection<double>(new List<double>(doubleCol));
			DoubleCol2 = new ReadOnlyCollection<double>(new List<double>(doubleCol2));
			HomeAddressProp = homeAddressProp;
			WorkAddressProp = workAddressProp;
		}
		
		protected BaseImmutablePerson(BaseImmutablePerson other)
		{
			var homeAddressCol = new List<ImmutableAddress>();
			foreach (ImmutableAddress otherItem in other.HomeAddressCol)
				homeAddressCol.Add(otherItem == null ? null : new ImmutableAddress(otherItem));
			HomeAddressCol = new ReadOnlyCollection<ImmutableAddress>(homeAddressCol);
			var workAddressCol = new List<ImmutableAddress>();
			workAddressCol.AddRange(other.WorkAddressCol);
			WorkAddressCol = new ReadOnlyCollection<ImmutableAddress>(workAddressCol);
			var stringCol = new List<string>();
			foreach (string otherItem in other.StringCol)
				stringCol.Add(otherItem == null ? null : string.Copy(otherItem));
			StringCol = new ReadOnlyCollection<string>(stringCol);
			var stringCol2 = new List<string>();
			stringCol2.AddRange(other.StringCol2);
			StringCol2 = new ReadOnlyCollection<string>(stringCol2);
			var doubleCol = new List<double>();
			doubleCol.AddRange(other.DoubleCol);
			DoubleCol = new ReadOnlyCollection<double>(doubleCol);
			var doubleCol2 = new List<double>();
			doubleCol2.AddRange(other.DoubleCol2);
			DoubleCol2 = new ReadOnlyCollection<double>(doubleCol2);
			if (other.HomeAddressProp == null)
				this.HomeAddressProp = null;
			else
				this.HomeAddressProp = new Address(other.HomeAddressProp);
			this.WorkAddressProp = other.WorkAddressProp;
		}
		
		public virtual ImmutablePerson WithHomeAddressProp(Address homeAddressProp)
		{
			return new ImmutablePerson(HomeAddressCol, WorkAddressCol, StringCol, StringCol2, DoubleCol, DoubleCol2, homeAddressProp, WorkAddressProp);
		}
		
		public virtual ImmutablePerson WithWorkAddressProp(Address workAddressProp)
		{
			return new ImmutablePerson(HomeAddressCol, WorkAddressCol, StringCol, StringCol2, DoubleCol, DoubleCol2, HomeAddressProp, workAddressProp);
		}
		
		#region Clone
		
#pragma warning disable 109
		public new ImmutablePerson Clone()
#pragma warning restore 109
		{
			return (ImmutablePerson) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new ImmutablePerson((ImmutablePerson) this);
		}
		
		#endregion Clone
	}
	
}
