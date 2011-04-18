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
	[DebuggerDisplay("Type1[Prop1={Prop1} Prop2={Prop2} Prop3={Prop3} Prop4={Prop4} Prop5={Prop5}]")]
	public abstract class BaseType1 : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, IDeserializationCallback, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string PROP1 = "Prop1";
			public const string PROP2 = "Prop2";
			public const string PROP3 = "Prop3";
			public const string PROP4 = "Prop4";
			public const string PROP5 = "Prop5";
			public const string COMP_LAZY = "CompLazy";
			public const string COMP = "Comp";
		}
		
		#endregion
		
		#region Constructors
		
		public BaseType1(Type2 prop2, int prop4, string prop5)
		{
			AddProp1Listeners(this.prop1);
			this.comp = new Type2();
			AddCompListeners(this.comp);
			this.prop2 = prop2;
			AddProp2Listeners(this.prop2);
			this.prop4 = prop4;
			this.prop5 = prop5;
			ValidateProp2(this.prop2);
			ValidateProp5(this.prop5);
		}
		
		public BaseType1(BaseType1 other)
		{
			this.prop1 = other.Prop1;
			AddProp1Listeners(this.prop1);
			this.prop2 = other.Prop2;
			AddProp2Listeners(this.prop2);
			this.prop3 = other.Prop3;
			this.prop4 = other.Prop4;
			this.prop5 = other.Prop5;
			if (other.compLazy != null)
			{
				this.compLazy = new Type2(other.CompLazy);
				AddCompLazyListeners(this.compLazy);
			}
			this.comp = new Type2(other.Comp);
			AddCompListeners(this.comp);
			ValidateProp2(this.prop2);
			ValidateProp5(this.prop5);
		}
		
		#endregion
		
		#region Property Prop1
		
		[DataMember(Name = "Prop1", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Type2 prop1;
		
		public Type2 Prop1
		{
			[DebuggerStepThrough]
			get {
				return GetProp1();
			}
			[DebuggerStepThrough]
			set {
				SetProp1(value);
			}
		}
		
		protected virtual Type2 GetProp1()
		{
			return this.prop1;
		}
		
		protected virtual bool SetProp1(Type2 prop1)
		{
			if (this.prop1 == prop1)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.PROP1);
			
			RemoveProp1Listeners(prop1);
			
			this.prop1 = prop1;
			
			AddProp1Listeners(prop1);
			
			NotifyPropertyChanged(PROPERTIES.PROP1);
			
			return true;
		}
		
		private void RemoveProp1Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= Prop1PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= Prop1ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= Prop1PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= Prop1ChildPropertyChangedEventHandler;
		}
		
		private void AddProp1Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += Prop1PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += Prop1ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += Prop1PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += Prop1ChildPropertyChangedEventHandler;
		}
		
		private void Prop1PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.PROP1, sender, e);
		}
		
		private void Prop1ChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.PROP1, sender, e);
		}
		
		private void Prop1PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.PROP1, sender, e);
		}
		
		private void Prop1ChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.PROP1, sender, e);
		}
		
		#endregion Property Prop1
		
		#region Property Prop2
		
		[DataMember(Name = "Prop2", Order = 1, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Type2 prop2;
		
		public Type2 Prop2
		{
			[DebuggerStepThrough]
			get {
				return GetProp2();
			}
			[DebuggerStepThrough]
			set {
				SetProp2(value);
			}
		}
		
		protected virtual Type2 GetProp2()
		{
			return this.prop2;
		}
		
		private void ValidateProp2(Type2 value)
		{
#pragma warning disable 219
			var property = PROPERTIES.PROP2;
#pragma warning restore 219
			
#pragma warning disable 472
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (value == null)
				throw new ArgumentNullException(property);
// ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 472
		}
		
		protected virtual bool SetProp2(Type2 prop2)
		{
			if (this.prop2 == prop2)
				return false;
			ValidateProp2(prop2);
			
			NotifyPropertyChanging(PROPERTIES.PROP2);
			
			RemoveProp2Listeners(prop2);
			
			this.prop2 = prop2;
			
			AddProp2Listeners(prop2);
			
			NotifyPropertyChanged(PROPERTIES.PROP2);
			
			return true;
		}
		
		private void RemoveProp2Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= Prop2PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= Prop2ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= Prop2PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= Prop2ChildPropertyChangedEventHandler;
		}
		
		private void AddProp2Listeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += Prop2PropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += Prop2ChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += Prop2PropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += Prop2ChildPropertyChangedEventHandler;
		}
		
		private void Prop2PropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.PROP2, sender, e);
		}
		
		private void Prop2ChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.PROP2, sender, e);
		}
		
		private void Prop2PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.PROP2, sender, e);
		}
		
		private void Prop2ChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.PROP2, sender, e);
		}
		
		#endregion Property Prop2
		
		#region Property Prop3
		
		[DataMember(Name = "Prop3", Order = 2, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int prop3;
		
		public int Prop3
		{
			[DebuggerStepThrough]
			get {
				return GetProp3();
			}
			[DebuggerStepThrough]
			set {
				SetProp3(value);
			}
		}
		
		protected virtual int GetProp3()
		{
			return this.prop3;
		}
		
		protected virtual bool SetProp3(int prop3)
		{
			if (this.prop3 == prop3)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.PROP3);
			
			this.prop3 = prop3;
			
			NotifyPropertyChanged(PROPERTIES.PROP3);
			
			return true;
		}
		
		#endregion Property Prop3
		
		#region Property Prop4
		
		[DataMember(Name = "Prop4", Order = 3, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int prop4;
		
		public int Prop4
		{
			[DebuggerStepThrough]
			get {
				return GetProp4();
			}
			[DebuggerStepThrough]
			set {
				SetProp4(value);
			}
		}
		
		protected virtual int GetProp4()
		{
			return this.prop4;
		}
		
		protected virtual bool SetProp4(int prop4)
		{
			if (this.prop4 == prop4)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.PROP4);
			
			this.prop4 = prop4;
			
			NotifyPropertyChanged(PROPERTIES.PROP4);
			
			return true;
		}
		
		#endregion Property Prop4
		
		#region Property Prop5
		
		[DataMember(Name = "Prop5", Order = 4, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string prop5;
		
		public string Prop5
		{
			[DebuggerStepThrough]
			get {
				return GetProp5();
			}
			[DebuggerStepThrough]
			set {
				SetProp5(value);
			}
		}
		
		protected virtual string GetProp5()
		{
			return this.prop5;
		}
		
		private void ValidateProp5(string value)
		{
#pragma warning disable 219
			var property = PROPERTIES.PROP5;
#pragma warning restore 219
			
#pragma warning disable 472
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (value == null)
				throw new ArgumentNullException(property);
// ReSharper restore ConditionIsAlwaysTrueOrFalse
#pragma warning restore 472
		}
		
		protected virtual bool SetProp5(string prop5)
		{
			if (this.prop5 == prop5)
				return false;
			ValidateProp5(prop5);
			
			NotifyPropertyChanging(PROPERTIES.PROP5);
			
			this.prop5 = prop5;
			
			NotifyPropertyChanged(PROPERTIES.PROP5);
			
			return true;
		}
		
		#endregion Property Prop5
		
		#region Property CompLazy
		
		[DataMember(Name = "CompLazy", Order = 5, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Type2 compLazy;
		
		public Type2 CompLazy
		{
			[DebuggerStepThrough]
			get {
				return GetCompLazy();
			}
		}
		
		protected virtual void LazyInitCompLazy()
		{
			if (this.compLazy != null)
				return;
				
			this.compLazy = new Type2();
			AddCompLazyListeners(this.compLazy);
		}
		
		protected virtual Type2 GetCompLazy()
		{
			LazyInitCompLazy();
			return this.compLazy;
		}
		
		private void AddCompLazyListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += CompLazyPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += CompLazyChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += CompLazyPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += CompLazyChildPropertyChangedEventHandler;
		}
		
		private void CompLazyPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.COMP_LAZY, sender, e);
		}
		
		private void CompLazyChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.COMP_LAZY, sender, e);
		}
		
		private void CompLazyPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.COMP_LAZY, sender, e);
		}
		
		private void CompLazyChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.COMP_LAZY, sender, e);
		}
		
		#endregion Property CompLazy
		
		#region Property Comp
		
		[DataMember(Name = "Comp", Order = 6, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Type2 comp;
		
		public Type2 Comp
		{
			[DebuggerStepThrough]
			get {
				return GetComp();
			}
		}
		
		protected virtual Type2 GetComp()
		{
			return this.comp;
		}
		
		private void AddCompListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += CompPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += CompChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += CompPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += CompChildPropertyChangedEventHandler;
		}
		
		private void CompPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.COMP, sender, e);
		}
		
		private void CompChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.COMP, sender, e);
		}
		
		private void CompPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.COMP, sender, e);
		}
		
		private void CompChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.COMP, sender, e);
		}
		
		#endregion Property Comp
		
		public virtual void CopyFrom(Type1 other)
		{
			Prop1 = other.Prop1;
			Prop2 = other.Prop2;
			Prop3 = other.Prop3;
			Prop4 = other.Prop4;
			Prop5 = other.Prop5;
			if (other.compLazy != null)
			{
				CompLazy.CopyFrom(other.CompLazy);
			}
			else
			{
				if (this.compLazy != null)
					this.compLazy.CopyFrom(new Type2());
			}
			Comp.CopyFrom(other.Comp);
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
		public new Type1 Clone()
#pragma warning restore 109
		{
			return (Type1) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Type1((Type1) this);
		}
		
		#endregion
		
		#region Serialization
		
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			AddProp1Listeners(this.prop1);
			AddProp2Listeners(this.prop2);
			AddCompLazyListeners(this.compLazy);
			AddCompListeners(this.comp);
		}
		
		#endregion
	}
	
}
