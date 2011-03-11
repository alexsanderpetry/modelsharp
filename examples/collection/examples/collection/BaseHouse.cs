// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.collection
{

	[DataContract]
	[DebuggerDisplay("House[Address={Address}]")]
	public abstract class BaseHouse : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string ADDRESS = "Address";
		}
		
		#endregion
		
		#region Constructors
		
		public BaseHouse()
		{
		}
		
		public BaseHouse(BaseHouse other)
		{
			this.address = other.Address;
		}
		
		#endregion
		
		#region Property Address
		
		[DataMember(Name = "Address", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string address;
		
		public string Address
		{
			[DebuggerStepThrough]
			get {
				return GetAddress();
			}
			[DebuggerStepThrough]
			set {
				SetAddress(value);
			}
		}
		
		protected virtual string GetAddress()
		{
			return this.address;
		}
		
		protected virtual bool SetAddress(string address)
		{
			if (this.address == address)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.ADDRESS);
			
			this.address = address;
			
			NotifyPropertyChanged(PROPERTIES.ADDRESS);
			
			return true;
		}
		
		#endregion Property Address
		
		public virtual void CopyFrom(House other)
		{
			Address = other.Address;
		}
		
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
		
		#endregion
		
		#region Clone
		
#pragma warning disable 109
		public new House Clone()
#pragma warning restore 109
		{
			return (House) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new House((House) this);
		}
		
		#endregion
	}
	
}
