// Automatically generated by Model#
// Remove the above line before editing this file and it won't be changed by Model#

using org.pescuma.ModelSharp.Lib;
using System.Collections.Specialized;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.deepCopy
{

	[DataContract(Name = "Person")]
	public class Person : BasePerson
	{
		public Person()
		: base()
		{
		}
		
		public Person(Person other)
		: base(other)
		{
		}
		
	}
	
}
