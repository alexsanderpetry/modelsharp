// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.lazy
{

	[DataContract]
	[DebuggerDisplay("Type2[Name={Name}]")]
	public abstract class BaseType2 : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string NAME = "Name";
		}
		
		#endregion
		
		#region Constructors
		
		public BaseType2()
		{
		}
		
		public BaseType2(BaseType2 other)
		{
			this.name = other.Name;
		}
		
		#endregion
		
		#region Property Name
		
		[DataMember(Name = "Name", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string name;
		
		public string Name
		{
			[DebuggerStepThrough]
			get {
				return GetName();
			}
			[DebuggerStepThrough]
			set {
				SetName(value);
			}
		}
		
		protected virtual string GetName()
		{
			return this.name;
		}
		
		protected virtual bool SetName(string name)
		{
			if (this.name == name)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.NAME);
			
			this.name = name;
			
			NotifyPropertyChanged(PROPERTIES.NAME);
			
			return true;
		}
		
		#endregion Property Name
		
		public virtual void CopyFrom(Type2 other)
		{
			Name = other.Name;
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
		public new Type2 Clone()
#pragma warning restore 109
		{
			return (Type2) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Type2((Type2) this);
		}
		
		#endregion
	}
	
}
