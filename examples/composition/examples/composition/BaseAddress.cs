// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.composition
{

	[DataContract]
	[DebuggerDisplay("Address[Street={Street} City={City} ZipCode={ZipCode}]")]
	public abstract class BaseAddress : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string STREET = "Street";
			public const string CITY = "City";
			public const string ZIP_CODE = "ZipCode";
		}
		
		#endregion
		
		#region Constructors
		
		public BaseAddress()
		{
		}
		
		public BaseAddress(BaseAddress other)
		{
			this._street = other.Street;
			this._city = other.City;
			this._zipCode = other.ZipCode;
		}
		
		#endregion
		
		#region Property Street
		
		[DataMember(Name = "Street", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _street;
		
		public string Street
		{
			[DebuggerStepThrough]
			get {
				return GetStreet();
			}
			[DebuggerStepThrough]
			set {
				SetStreet(value);
			}
		}
		
		protected virtual string GetStreet()
		{
			return this._street;
		}
		
		protected virtual bool SetStreet(string street)
		{
			if (this._street == street)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.STREET);
			
			this._street = street;
			
			NotifyPropertyChanged(PROPERTIES.STREET);
			
			return true;
		}
		
		#endregion Property Street
		
		#region Property City
		
		[DataMember(Name = "City", Order = 1, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _city;
		
		public string City
		{
			[DebuggerStepThrough]
			get {
				return GetCity();
			}
			[DebuggerStepThrough]
			set {
				SetCity(value);
			}
		}
		
		protected virtual string GetCity()
		{
			return this._city;
		}
		
		protected virtual bool SetCity(string city)
		{
			if (this._city == city)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.CITY);
			
			this._city = city;
			
			NotifyPropertyChanged(PROPERTIES.CITY);
			
			return true;
		}
		
		#endregion Property City
		
		#region Property ZipCode
		
		[DataMember(Name = "ZipCode", Order = 2, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _zipCode;
		
		public string ZipCode
		{
			[DebuggerStepThrough]
			get {
				return GetZipCode();
			}
			[DebuggerStepThrough]
			set {
				SetZipCode(value);
			}
		}
		
		protected virtual string GetZipCode()
		{
			return this._zipCode;
		}
		
		protected virtual bool SetZipCode(string zipCode)
		{
			if (this._zipCode == zipCode)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.ZIP_CODE);
			
			this._zipCode = zipCode;
			
			NotifyPropertyChanged(PROPERTIES.ZIP_CODE);
			
			return true;
		}
		
		#endregion Property ZipCode
		
		public virtual void CopyFrom(Address other)
		{
			Street = other.Street;
			City = other.City;
			ZipCode = other.ZipCode;
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
				handler(sender, new ChildPropertyChangingEventArgs(this, propertyName, e));
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
		public new Address Clone()
#pragma warning restore 109
		{
			return (Address) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Address((Address) this);
		}
		
		#endregion
	}
	
}
