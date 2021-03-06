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

namespace examples.doc
{

	/// <summary>
	/// A point, man!
	/// </summary>
	[DataContract]
	[DebuggerDisplay("ImmutablePoint[X={X} Ws={Ws.Count}items]")]
	[GeneratedCode("Model#", "0.2.1.0")]
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
		public readonly Point Y;
		
		/// <summary>
		/// All the ws you can find
		/// </summary>
		[DataMember(Name = "Ws", Order = 2, IsRequired = false)]
		public readonly ReadOnlyCollection<double> Ws;
		
		protected BaseImmutablePoint(double x, Point y, IEnumerable<double> ws)
		{
			X = x;
			Y = y;
			Ws = new ReadOnlyCollection<double>(new List<double>(ws));
		}
		
		protected BaseImmutablePoint(BaseImmutablePoint other)
		{
			this.X = other.X;
			this.Y = new Point(other.Y);
			var ws = new List<double>();
			ws.AddRange(other.Ws);
			Ws = new ReadOnlyCollection<double>(ws);
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
		
		[DebuggerStepThrough]
		protected abstract double ComputeLen();
		
		#region Clone
		
#pragma warning disable 109
		public new ImmutablePoint Clone()
#pragma warning restore 109
		{
			return (ImmutablePoint) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new ImmutablePoint((ImmutablePoint) this);
		}
		
		#endregion Clone
	}
	
}
