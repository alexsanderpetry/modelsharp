// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.extends
{

	[DataContract]
	[DebuggerDisplay("B[Date2={Date2}]")]
	public abstract class BaseB : A, INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, IDeserializationCallback, ICloneable
	{
		#region Field Name Defines
		
		public new class PROPERTIES : A.PROPERTIES
		{
			public const string DATE2 = "Date2";
		}
		
		#endregion
		
		#region Constructors
		
		public BaseB()
		{
			AddDate2Listeners(this.date2);
		}
		
		public BaseB(BaseB other)
		: base(other)
		{
			this.date2 = other.Date2;
			AddDate2Listeners(this.date2);
		}
		
		#endregion
		
		#region Property Date2
		
		[DataMember(Name = "Date2", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DateTime date2;
		
		public DateTime Date2
		{
			[DebuggerStepThrough]
			get {
				return GetDate2();
			}
			[DebuggerStepThrough]
			set {
				SetDate2(value);
			}
		}
		
		protected virtual DateTime GetDate2()
		{
			return this.date2;
		}
		
		protected virtual bool SetDate2(DateTime date2)
		{
			if (this.date2 == date2)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.DATE2);
			
			RemoveDate2Listeners(date2);
			
			this.date2 = date2;
			
			AddDate2Listeners(date2);
			
			NotifyPropertyChanged(PROPERTIES.DATE2);
			
			return true;
		}
		
		private void RemoveDate2Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= Date2PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= Date2ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= Date2PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= Date2ChildPropertyChangedEventHandler;
		}
		
		private void AddDate2Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += Date2PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += Date2ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += Date2PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += Date2ChildPropertyChangedEventHandler;
		}
		
		private void Date2PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.DATE2, sender, e);
		}
		
		private void Date2ChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.DATE2, sender, e);
		}
		
		private void Date2PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.DATE2, sender, e);
		}
		
		private void Date2ChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.DATE2, sender, e);
		}
		
		#endregion Property Date2
		
		public virtual void CopyFrom(B other)
		{
			base.CopyFrom(other);
			Date2 = other.Date2;
		}
		
		#region Property Notification
		
		#endregion
		
		#region Clone
		
#pragma warning disable 109
		public new B Clone()
#pragma warning restore 109
		{
			return (B) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new B((B) this);
		}
		
		#endregion
		
		#region Serialization
		
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			// Call OnDeserialization in base class if it exists
			if (typeof(A).GetInterface(typeof(IDeserializationCallback).FullName) != null)
			{
				var map = typeof(A).GetInterfaceMap(typeof(IDeserializationCallback));
				map.TargetMethods[0].Invoke(this, new[] { sender });
			}
			
			AddDate2Listeners(this.date2);
		}
		
		#endregion
	}
	
}
