//----------------------
// <auto-generated>
//     Automatically generated by Model#
// </auto-generated>
//----------------------
// DO NOT EDIT THIS FILE

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.extends
{

	[DataContract]
	[DebuggerDisplay("S2[Date2={Date2}]")]
	[GeneratedCode("Model#", "0.2.0.0")]
	public abstract class BaseS2 : List<string>, INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, IDeserializationCallback, ICloneable, ICopyable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public static readonly string DATE2 = ModelUtils.NameOfProperty((BaseS2 o) => o.Date2);
			
			protected PROPERTIES() {}
		}
		
		#endregion
		
		#region Constructors
		
		protected BaseS2()
		{
			AddDate2Listeners(this.date2);
		}
		
		protected BaseS2(BaseS2 other)
		: base(other)
		{
			this.date2 = other.Date2;
			AddDate2Listeners(this.date2);
		}
		
		#endregion Constructors
		
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
		
		[DebuggerStepThrough]
		protected virtual DateTime GetDate2()
		{
			return this.date2;
		}
		
		[DebuggerStepThrough]
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
			CopyFrom((S2) other);
		}
		
		public virtual void CopyFrom(S2 other)
		{
			Date2 = other.Date2;
		}
		
		#endregion CopyFrom
		
		#region Clone
		
#pragma warning disable 109
		public new S2 Clone()
#pragma warning restore 109
		{
			return (S2) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new S2((S2) this);
		}
		
		#endregion Clone
		
		#region Serialization
		
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			// Call OnDeserialization in base class if it exists
			if (typeof(List<string>).GetInterface(typeof(IDeserializationCallback).FullName) != null)
			{
				var map = typeof(List<string>).GetInterfaceMap(typeof(IDeserializationCallback));
				map.TargetMethods[0].Invoke(this, new[] { sender });
			}
			
			AddDate2Listeners(this.date2);
		}
		
		#endregion Serialization
	}
	
}