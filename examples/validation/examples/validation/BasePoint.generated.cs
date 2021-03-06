//----------------------
// <auto-generated>
//     Automatically generated by Model#
// </auto-generated>
//----------------------
// DO NOT EDIT THIS FILE

using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.validation
{

	[DataContract]
	[DebuggerDisplay("Point[X={X} Y={Y} Z={Z} W={W}]")]
	[GeneratedCode("Model#", "0.2.1.0")]
	public abstract class BasePoint : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, ICloneable, ICopyable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public static readonly string X = ModelUtils.NameOfProperty((BasePoint o) => o.X);
			public static readonly string Y = ModelUtils.NameOfProperty((BasePoint o) => o.Y);
			public static readonly string Z = ModelUtils.NameOfProperty((BasePoint o) => o.Z);
			public static readonly string W = ModelUtils.NameOfProperty((BasePoint o) => o.W);
			public static readonly string COMP = ModelUtils.NameOfProperty((BasePoint o) => o.Comp);
			
			protected PROPERTIES() {}
		}
		
		#endregion
		
		#region Constructors
		
		protected BasePoint(double x, double w)
		{
			this.y = 2;
			this.comp = new Point(2,2);
			AddCompListeners(this.comp);
			this.x = x;
			this.w = w;
			ValidateX(this.x);
			ValidateY(this.y);
			ValidateZ(this.z);
			ValidateW(this.w);
			ValidateComp(this.comp);
		}
		
		protected BasePoint(BasePoint other)
		{
			this.x = other.X;
			this.y = other.Y;
			this.z = other.Z;
			this.w = other.W;
			this.comp = new Point(other.Comp);
			AddCompListeners(this.comp);
			ValidateX(this.x);
			ValidateY(this.y);
			ValidateZ(this.z);
			ValidateW(this.w);
			ValidateComp(this.comp);
		}
		
		#endregion Constructors
		
		#region Property X
		
		[DataMember(Name = "X", Order = 0, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double x;
		
		public double X
		{
			[DebuggerStepThrough]
			get {
				return GetX();
			}
			[DebuggerStepThrough]
			set {
				SetX(value);
			}
		}
		
		[DebuggerStepThrough]
		protected virtual double GetX()
		{
			return this.x;
		}
		
		private void ValidateX(double value)
		{
#pragma warning disable 219
			var property = PROPERTIES.X;
#pragma warning restore 219
			
			if (!(value > 0))
				throw new Exception();
		}
		
		[DebuggerStepThrough]
		protected virtual bool SetX(double x)
		{
			if (Math.Abs(this.x - x) < 1E-06)
				return false;
			ValidateX(x);
			
			NotifyPropertyChanging(PROPERTIES.X);
			
			this.x = x;
			
			NotifyPropertyChanged(PROPERTIES.X);
			
			return true;
		}
		
		#endregion Property X
		
		#region Property Y
		
		[DataMember(Name = "Y", Order = 1, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double y;
		
		[Range(5, 7)]
		public double Y
		{
			[DebuggerStepThrough]
			get {
				return GetY();
			}
			[DebuggerStepThrough]
			set {
				SetY(value);
			}
		}
		
		[DebuggerStepThrough]
		protected virtual double GetY()
		{
			return this.y;
		}
		
		private void ValidateY(double value)
		{
#pragma warning disable 219
			var property = PROPERTIES.Y;
#pragma warning restore 219
			
			if (!new RangeAttribute(5, 7).IsValid(value))
				throw new ArgumentException("Range(5, 7)", property);
		}
		
		[DebuggerStepThrough]
		protected virtual bool SetY(double y)
		{
			if (Math.Abs(this.y - y) < 1E-06)
				return false;
			ValidateY(y);
			
			NotifyPropertyChanging(PROPERTIES.Y);
			
			this.y = y;
			
			NotifyPropertyChanged(PROPERTIES.Y);
			
			return true;
		}
		
		#endregion Property Y
		
		#region Property Z
		
		[DataMember(Name = "Z", Order = 2, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double z;
		
		[Required]
		[Range(1, 6)]
		public double Z
		{
			[DebuggerStepThrough]
			get {
				return GetZ();
			}
			[DebuggerStepThrough]
			set {
				SetZ(value);
			}
		}
		
		[DebuggerStepThrough]
		protected virtual double GetZ()
		{
			return this.z;
		}
		
		private void ValidateZ(double value)
		{
#pragma warning disable 219
			var property = PROPERTIES.Z;
#pragma warning restore 219
			
			if (!(value > 0))
				throw new ArgumentException("value > 0", property);
				
			if (!(value < 100))
				throw new Exception();
				
			if (!new RequiredAttribute().IsValid(value))
				throw new ArgumentException("Required", property);
				
			if (!new RangeAttribute(1, 6).IsValid(value))
				throw new Exception();
		}
		
		[DebuggerStepThrough]
		protected virtual bool SetZ(double z)
		{
			if (Math.Abs(this.z - z) < 1E-06)
				return false;
			ValidateZ(z);
			
			NotifyPropertyChanging(PROPERTIES.Z);
			
			this.z = z;
			
			NotifyPropertyChanged(PROPERTIES.Z);
			
			return true;
		}
		
		#endregion Property Z
		
		#region Property W
		
		[DataMember(Name = "W", Order = 3, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double w;
		
		[StringLength(10)]
		[Required]
		[Range(1, 6)]
		public double W
		{
			[DebuggerStepThrough]
			get {
				return GetW();
			}
			[DebuggerStepThrough]
			set {
				SetW(value);
			}
		}
		
		[DebuggerStepThrough]
		protected virtual double GetW()
		{
			return this.w;
		}
		
		private void ValidateW(double value)
		{
#pragma warning disable 219
			var property = PROPERTIES.W;
#pragma warning restore 219
			
			if (!new StringLengthAttribute(10).IsValid(value))
				throw new Exception();
				
			if (!(value > -10))
				throw new Exception();
				
			if (!(value > 0))
				throw new ArgumentException("value > 0", property);
				
			if (!(value < 100))
				throw new Exception();
				
			if (!new RequiredAttribute().IsValid(value))
				throw new ArgumentException("Required", property);
				
			if (!new RangeAttribute(1, 6).IsValid(value))
				throw new Exception();
		}
		
		[DebuggerStepThrough]
		protected virtual bool SetW(double w)
		{
			if (Math.Abs(this.w - w) < 1E-06)
				return false;
			ValidateW(w);
			
			NotifyPropertyChanging(PROPERTIES.W);
			
			this.w = w;
			
			NotifyPropertyChanged(PROPERTIES.W);
			
			return true;
		}
		
		#endregion Property W
		
		#region Property Comp
		
		[DataMember(Name = "Comp", Order = 4, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point comp;
		
		[StringLength(10)]
		[Required]
		[Range(1, 6)]
		public Point Comp
		{
			[DebuggerStepThrough]
			get {
				return GetComp();
			}
		}
		
		[DebuggerStepThrough]
		protected virtual Point GetComp()
		{
			return this.comp;
		}
		
		private void ValidateComp(Point value)
		{
#pragma warning disable 219
			var property = PROPERTIES.COMP;
#pragma warning restore 219
			
			if (!new StringLengthAttribute(10).IsValid(value))
				throw new Exception("x");
				
			if (!(value.X > -10))
				throw new Exception("x");
				
			if (!(value.X > 0))
				throw new ArgumentException("value.X > 0", property);
				
			if (!(value.Y < 100))
				throw new Exception();
				
			if (!new RequiredAttribute().IsValid(value))
				throw new ArgumentException("Required", property);
				
			if (!new RangeAttribute(1, 6).IsValid(value))
				throw new Exception();
		}
		
		private void AddCompListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += CompPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += CompChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += CompPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += CompChildPropertyChangedEventHandler;
		}
		
		private void CompPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.COMP, sender, e);
		}
		
		private void CompChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.COMP, sender, e);
		}
		
		private void CompPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.COMP, sender, e);
		}
		
		private void CompChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.COMP, sender, e);
		}
		
		#endregion Property Comp
		
		#region Property Notification
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		protected virtual void NotifyPropertyChanging(string propertyName)
		{
			PropertyChangingEventHandler handler = PropertyChanging;
			if (handler != null)
				handler(this, new PropertyChangingEventArgs(propertyName));
		}
		
		public event ChildPropertyChangingEventHandler ChildPropertyChanging;
		
		protected virtual void NotifyChildPropertyChanging(string propertyName, object sender, PropertyChangingEventArgs e)
		{
			ChildPropertyChangingEventHandler handler = ChildPropertyChanging;
			if (handler != null)
				handler(sender, new ChildPropertyChangingEventArgs(this, propertyName, sender, e));
		}
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void NotifyPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
		
		public event ChildPropertyChangedEventHandler ChildPropertyChanged;
		
		protected virtual void NotifyChildPropertyChanged(string propertyName, object sender, PropertyChangedEventArgs e)
		{
			ChildPropertyChangedEventHandler handler = ChildPropertyChanged;
			if (handler != null)
				handler(sender, new ChildPropertyChangedEventArgs(this, propertyName, sender, e));
		}
		
		#endregion Property Notification
		
		#region CopyFrom
		
		void ICopyable.CopyFrom(object other)
		{
			CopyFrom((Point) other);
		}
		
		public virtual void CopyFrom(Point other)
		{
			X = other.X;
			Y = other.Y;
			Z = other.Z;
			W = other.W;
			Comp.CopyFrom(other.Comp);
		}
		
		#endregion CopyFrom
		
		#region Clone
		
#pragma warning disable 109
		public new Point Clone()
#pragma warning restore 109
		{
			return (Point) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Point((Point) this);
		}
		
		#endregion Clone
		
		#region Serialization
		
		[OnDeserializing]
		private void OnDeserializing(StreamingContext context)
		{
			this.y = 2;
			this.comp = new Point(2,2);
		}
		
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			AddCompListeners(this.comp);
		}
		
		#endregion Serialization
	}
	
}
