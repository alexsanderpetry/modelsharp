// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System;
using System.ComponentModel;
using org.pescuma.ModelSharp.Lib;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.required
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
			_name = other.Name;
		}
		
		#endregion
		
		#region Property Name
		
		[DataMember(Name = "Name", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string _name;
		
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
			return _name;
		}
		
		protected virtual bool SetName(string name)
		{
			if (_name == name)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.NAME);
			
			_name = name;
			
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
		
		public event ChildPropertyChangingEventHandler ChildPropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		public event ChildPropertyChangedEventHandler ChildPropertyChanged;
		
		protected virtual void NotifyPropertyChanging(string propertyName)
		{
			PropertyChangingEventHandler handler = PropertyChanging;
			if (handler != null)
				handler(this, new PropertyChangingEventArgs(propertyName));
		}
		
		protected virtual void NotifyChildPropertyChanging(string propertyName, object sender, PropertyChangingEventArgs e)
		{
			ChildPropertyChangingEventHandler handler = ChildPropertyChanging;
			if (handler != null)
				handler(sender, new ChildPropertyChangingEventArgs(this, propertyName, e));
		}
		
		protected virtual void NotifyPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
		
		protected virtual void NotifyChildPropertyChanged(string propertyName, object sender, PropertyChangedEventArgs e)
		{
			ChildPropertyChangedEventHandler handler = ChildPropertyChanged;
			if (handler != null)
				handler(sender, new ChildPropertyChangedEventArgs(this, propertyName, e));
		}
		
		#endregion
		
		#region Clone
		
		public Type2 Clone()
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
