//----------------------
// <auto-generated>
//     Automatically generated by Model#
// </auto-generated>
//----------------------
// DO NOT EDIT THIS FILE

using System.CodeDom.Compiler;
using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.config1
{

	[DataContract(Namespace = "data")]
	[DebuggerDisplay("Line[P1={P1} P2={P2}]")]
	[GeneratedCode("Model#", "0.2.0.0")]
	public abstract class BaseLine : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, IDeserializationCallback, ICloneable, ICopyable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public static readonly string P1 = ModelUtils.NameOfProperty((BaseLine o) => o.P1);
			public static readonly string P2 = ModelUtils.NameOfProperty((BaseLine o) => o.P2);
			
			protected PROPERTIES() {}
		}
		
		#endregion
		
		#region Constructors
		
		protected BaseLine()
		{
			AddP1Listeners(this.p1);
			AddP2Listeners(this.p2);
		}
		
		protected BaseLine(BaseLine other)
		{
			this.p1 = other.P1;
			AddP1Listeners(this.p1);
			this.p2 = other.P2;
			AddP2Listeners(this.p2);
		}
		
		#endregion Constructors
		
		#region Property P1
		
		[DataMember(Name = "P1", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point p1;
		
		public Point P1
		{
			[DebuggerStepThrough]
			get {
				return GetP1();
			}
			[DebuggerStepThrough]
			set {
				SetP1(value);
			}
		}
		
		[DebuggerStepThrough]
		protected virtual Point GetP1()
		{
			return this.p1;
		}
		
		[DebuggerStepThrough]
		protected virtual bool SetP1(Point p1)
		{
			if (this.p1 == p1)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.P1);
			
			RemoveP1Listeners(this.p1);
			
			this.p1 = p1;
			
			AddP1Listeners(this.p1);
			
			NotifyPropertyChanged(PROPERTIES.P1);
			
			return true;
		}
		
		private void RemoveP1Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= P1PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= P1ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= P1PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= P1ChildPropertyChangedEventHandler;
		}
		
		private void AddP1Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += P1PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += P1ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += P1PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += P1ChildPropertyChangedEventHandler;
		}
		
		private void P1PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.P1, sender, e);
		}
		
		private void P1ChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.P1, sender, e);
		}
		
		private void P1PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.P1, sender, e);
		}
		
		private void P1ChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.P1, sender, e);
		}
		
		#endregion Property P1
		
		#region Property P2
		
		[DataMember(Name = "P2", Order = 1, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Point p2;
		
		public Point P2
		{
			[DebuggerStepThrough]
			get {
				return GetP2();
			}
			[DebuggerStepThrough]
			set {
				SetP2(value);
			}
		}
		
		[DebuggerStepThrough]
		protected virtual Point GetP2()
		{
			return this.p2;
		}
		
		[DebuggerStepThrough]
		protected virtual bool SetP2(Point p2)
		{
			if (this.p2 == p2)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.P2);
			
			RemoveP2Listeners(this.p2);
			
			this.p2 = p2;
			
			AddP2Listeners(this.p2);
			
			NotifyPropertyChanged(PROPERTIES.P2);
			
			return true;
		}
		
		private void RemoveP2Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= P2PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= P2ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= P2PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= P2ChildPropertyChangedEventHandler;
		}
		
		private void AddP2Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += P2PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += P2ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += P2PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += P2ChildPropertyChangedEventHandler;
		}
		
		private void P2PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.P2, sender, e);
		}
		
		private void P2ChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.P2, sender, e);
		}
		
		private void P2PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.P2, sender, e);
		}
		
		private void P2ChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.P2, sender, e);
		}
		
		#endregion Property P2
		
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
			CopyFrom((Line) other);
		}
		
		public virtual void CopyFrom(Line other)
		{
			P1 = other.P1;
			P2 = other.P2;
		}
		
		#endregion CopyFrom
		
		#region Clone
		
#pragma warning disable 109
		public new Line Clone()
#pragma warning restore 109
		{
			return (Line) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Line((Line) this);
		}
		
		#endregion Clone
		
		#region Serialization
		
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			AddP1Listeners(this.p1);
			AddP2Listeners(this.p2);
		}
		
		#endregion Serialization
	}
	
}