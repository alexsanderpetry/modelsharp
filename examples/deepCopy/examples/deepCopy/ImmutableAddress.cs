// Automatically generated by Model#
// Remove the above line before editing this file and it won't be changed by Model#

using System.Runtime.Serialization;
using System.Diagnostics;
using System;

namespace examples.deepCopy
{

	[DataContract(Name = "ImmutableAddress")]
	public class ImmutableAddress : BaseImmutableAddress
	{
		public ImmutableAddress(string street, string city, string zipCode)
		: base(street, city, zipCode)
		{
		}
		
		public ImmutableAddress(ImmutableAddress other)
		: base(other)
		{
		}
		
	}
	
}
