//----------------------
// <auto-generated>
//     Automatically generated by Model#
// </auto-generated>
//----------------------
// DO NOT EDIT THIS FILE

using System.CodeDom.Compiler;
using System.Collections;
using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.implements
{

	[DataContract]
	[DebuggerDisplay("Test[Date={Date}]")]
	[GeneratedCode("Model#", "0.2.0.0")]
	public abstract class BaseTest : IDummy, IDummy2, INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, IDeserializationCallback, ICloneable, ICopyable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public static readonly string DATE = ModelUtils.NameOfParameter(Date => {});
			
			protected PROPERTIES() {}
		}
		
		#endregion
		
		#region Constructors
		
		protected BaseTest()
		{
			AddDateListeners(this.date);
		}
		
		protected BaseTest(BaseTest other)
		{
			this.date = other.Date;
			AddDateListeners(this.date);
		}
		
		#endregion Constructors
		
		#region Property Date
		
		[DataMember(Name = "Date", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DateTime date;
		
		public DateTime Date
		{
			[DebuggerStepThrough]
			get {
				return GetDate();
			}
			[DebuggerStepThrough]
			set {
				SetDate(value);
			}
		}
		
		[DebuggerStepThrough]
		protected virtual DateTime GetDate()
		{
			return this.date;
		}
		
		[DebuggerStepThrough]
		protected virtual bool SetDate(DateTime date)
		{
			if (this.date == date)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.DATE);
			
			RemoveDateListeners(date);
			
			this.date = date;
			
			AddDateListeners(date);
			
			NotifyPropertyChanged(PROPERTIES.DATE);
			
			return true;
		}
		
		private void RemoveDateListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= DatePropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= DateChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= DatePropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= DateChildPropertyChangedEventHandler;
		}
		
		private void AddDateListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += DatePropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += DateChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += DatePropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += DateChildPropertyChangedEventHandler;
		}
		
		private void DatePropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.DATE, sender, e);
		}
		
		private void DateChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.DATE, sender, e);
		}
		
		private void DatePropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.DATE, sender, e);
		}
		
		private void DateChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.DATE, sender, e);
		}
		
		#endregion Property Date
		
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
			CopyFrom((Test) other);
		}
		
		public virtual void CopyFrom(Test other)
		{
			Date = other.Date;
		}
		
		#endregion CopyFrom
		
		#region Clone
		
#pragma warning disable 109
		public new Test Clone()
#pragma warning restore 109
		{
			return (Test) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Test((Test) this);
		}
		
		#endregion Clone
		
		#region Serialization
		
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			AddDateListeners(this.date);
		}
		
		#endregion Serialization
	}
	
}
