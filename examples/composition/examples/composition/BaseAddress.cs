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
			_street = other.Street;
			_city = other.City;
			_zipCode = other.ZipCode;
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
			return _street;
		}
		
		protected virtual bool SetStreet(string street)
		{
			if (_street == street)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.STREET);
			
			_street = street;
			
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
			return _city;
		}
		
		protected virtual bool SetCity(string city)
		{
			if (_city == city)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.CITY);
			
			_city = city;
			
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
			return _zipCode;
		}
		
		protected virtual bool SetZipCode(string zipCode)
		{
			if (_zipCode == zipCode)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.ZIP_CODE);
			
			_zipCode = zipCode;
			
			NotifyPropertyChanged(PROPERTIES.ZIP_CODE);
			
			return true;
		}
		
		#endregion Property ZipCode
		
		#region Get/Set by name and CopyFrom
		
		public object GetField(string fieldName)
		{
			switch (fieldName)
			{
				case PROPERTIES.STREET:
					return GetStreet();
				case PROPERTIES.CITY:
					return GetCity();
				case PROPERTIES.ZIP_CODE:
					return GetZipCode();
			}
			
			throw new ArgumentException("No gettable field named " + fieldName);
		}
		
		public void SetField(string fieldName, object value)
		{
			switch (fieldName)
			{
				case PROPERTIES.STREET:
					if (!(value is string))
						throw new ArgumentException(fieldName + " must be of type string");
						
					SetStreet((string) value);
					
					return;
				case PROPERTIES.CITY:
					if (!(value is string))
						throw new ArgumentException(fieldName + " must be of type string");
						
					SetCity((string) value);
					
					return;
				case PROPERTIES.ZIP_CODE:
					if (!(value is string))
						throw new ArgumentException(fieldName + " must be of type string");
						
					SetZipCode((string) value);
					
					return;
			}
			
			throw new ArgumentException("No settable field named " + fieldName);
		}
		
		public void CopyFrom(Address other)
		{
			Street = other.Street;
			City = other.City;
			ZipCode = other.ZipCode;
		}
		
		#endregion
		
		#region Property Notification
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event ChildPropertyChangingEventHandler ChildPropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event ChildPropertyChangedEventHandler ChildPropertyChanged;
		
		protected void NotifyPropertyChanging(string propertyName)
		{
			PropertyChangingEventHandler handler = PropertyChanging;
			if (handler != null)
				handler(this, new PropertyChangingEventArgs(propertyName));
		}
		
		protected void NotifyChildPropertyChanging(string propertyName, object sender, PropertyChangingEventArgs e)
		{
			ChildPropertyChangingEventHandler handler = ChildPropertyChanging;
			if (handler != null)
				handler(sender, new ChildPropertyChangingEventArgs(this, propertyName, e));
		}
		
		protected void NotifyPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
		
		protected void NotifyChildPropertyChanged(string propertyName, object sender, PropertyChangedEventArgs e)
		{
			ChildPropertyChangedEventHandler handler = ChildPropertyChanged;
			if (handler != null)
				handler(sender, new ChildPropertyChangedEventArgs(this, propertyName, e));
		}
		
		#endregion
		
		#region Clone
		
		public Address Clone()
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