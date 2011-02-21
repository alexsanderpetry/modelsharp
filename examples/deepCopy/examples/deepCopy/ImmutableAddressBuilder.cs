// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.deepCopy
{

	public class ImmutableAddressBuilder
	{
		private string _street;
		private string _city;
		private string _zipCode;
		
		public virtual ImmutableAddressBuilder Set(ImmutableAddress other)
		{
			SetStreet(other.Street);
			SetCity(other.City);
			SetZipCode(other.ZipCode);
			return this;
		}
		
		public virtual ImmutableAddressBuilder SetStreet(string street)
		{
			_street = street;
			return this;
		}
		
		public virtual ImmutableAddressBuilder SetCity(string city)
		{
			_city = city;
			return this;
		}
		
		public virtual ImmutableAddressBuilder SetZipCode(string zipCode)
		{
			_zipCode = zipCode;
			return this;
		}
		
		public virtual ImmutableAddress Build()
		{
			return new ImmutableAddress(_street, _city, _zipCode);
		}
	}
	
}
