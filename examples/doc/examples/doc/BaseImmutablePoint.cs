// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.doc
{

	/// <summary>
	/// A point, man!
	/// </summary>
	[DataContract]
	[DebuggerDisplay("ImmutablePoint[X={X} Ws={Ws.Count}items]")]
	public abstract class BaseImmutablePoint : ICloneable
	{
		/// <summary>
		/// The X cartesian coord
		/// </summary>
		[DataMember(Name = "X", Order = 0, IsRequired = false)]
		public readonly double X;
		
		/// <summary>
		/// Y, oh Y
		/// </summary>
		[DataMember(Name = "Y", Order = 1, IsRequired = true)]
		public readonly double Y;
		
		/// <summary>
		/// All the ws you can find
		/// </summary>
		[DataMember(Name = "Ws", Order = 2, IsRequired = false)]
		public readonly ReadOnlyCollection<double> Ws;
		
		public BaseImmutablePoint(double x, double y, IEnumerable<double> ws)
		{
			X = x;
			Y = y;
			Ws = new ReadOnlyCollection<double>(new List<double>(ws));
		}
		
		public BaseImmutablePoint(BaseImmutablePoint other)
		{
			X = other.X;
			Y = new double(other.Y);
			Ws = new ReadOnlyCollection<double>(new List<double>(other.Ws));
		}
		
		public virtual ImmutablePoint WithX(double x)
		{
			return new ImmutablePoint(x, Y, Ws);
		}
		
		/// <summary>
		/// x*x + y*Y sqrt
		/// </summary>
		public double Len
		{
			[DebuggerStepThrough]
			get {
				return ComputeLen();
			}
		}
		
		protected abstract double ComputeLen();
		
		public ImmutablePoint Clone()
		{
			return (ImmutablePoint) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new ImmutablePoint((ImmutablePoint) this);
		}
	}
	
}
