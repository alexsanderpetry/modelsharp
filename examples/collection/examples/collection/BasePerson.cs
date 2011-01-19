// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using org.pescuma.ModelSharp.Lib;
using System.Collections.Specialized;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.collection
{

	[DataContract]
	[DebuggerDisplay("Person[Cars={Cars.Count}items Name={Name} Houses={Houses.Count}items]")]
	public abstract class BasePerson : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string CARS = "Cars";
			public const string NAME = "Name";
			public const string HOUSES = "Houses";
		}
		
		#endregion
		
		#region Constructors
		
		public BasePerson()
		{
			_cars = new ObservableList<string>();
			AddCarsListListeners(_cars);
			_houses = new ObservableList<House>();
			AddHousesListListeners(_houses);
		}
		
		public BasePerson(BasePerson other)
		{
			_cars = new ObservableList<string>(other.Cars);
			AddCarsListListeners(_cars);
			_name = other.Name;
			_houses = new ObservableList<House>(other.Houses);
			AddHousesListListeners(_houses);
		}
		
		#endregion
		
		#region Property Cars
		
		[DataMember(Name = "Cars", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<string> _cars;
		
		public ObservableList<string> Cars
		{
			[DebuggerStepThrough]
			get {
				return GetCars();
			}
		}
		
		protected virtual ObservableList<string> GetCars()
		{
			return _cars;
		}
		
		private void AddCarsListListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += CarsListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += CarsListPropertyChangedEventHandler;
		}
		
		private void CarsListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<string>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.CARS);
		}
		
		private void CarsListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<string>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.CARS);
		}
		
		#endregion Property Cars
		
		#region Property Name
		
		[DataMember(Name = "Name", Order = 1, IsRequired = false)]
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
		
		#region Property Houses
		
		[DataMember(Name = "Houses", Order = 2, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<House> _houses;
		
		public ObservableList<House> Houses
		{
			[DebuggerStepThrough]
			get {
				return GetHouses();
			}
		}
		
		protected virtual ObservableList<House> GetHouses()
		{
			return _houses;
		}
		
		private void AddHousesListListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += HousesListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += HousesListPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyCollectionChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.CollectionChanged += HousesListChangedEventHandler;
		}
		
		private void HousesListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<House>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.HOUSES);
		}
		
		private void HousesListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<House>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.HOUSES);
		}
		
		private void HousesListChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
				case NotifyCollectionChangedAction.Remove:
				case NotifyCollectionChangedAction.Replace:
				
					if ((e.OldItems == null || e.OldItems.Count == 0)
					        && (e.NewItems == null || e.NewItems.Count == 0))
						throw new InvalidOperationException();
						
					if (e.OldItems != null)
						foreach (var item in e.OldItems)
							RemoveHousesItemListeners(item);
							
					if (e.NewItems != null)
						foreach (var item in e.NewItems)
							AddHousesItemListeners(item);
							
					break;
				case NotifyCollectionChangedAction.Move:
					// Do nothing
					break;
				default:
					// NotifyCollectionChangedAction.Reset: The list should not fire this or
					// we can't control the items
					throw new InvalidOperationException();
			}
		}
		
		private void RemoveHousesItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= HousesItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= HousesItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= HousesItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= HousesItemChildPropertyChangedEventHandler;
		}
		
		private void AddHousesItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += HousesItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += HousesItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += HousesItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += HousesItemChildPropertyChangedEventHandler;
		}
		
		private void HousesItemPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.HOUSES, sender, e);
		}
		
		private void HousesItemChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.HOUSES, sender, e);
		}
		
		private void HousesItemPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.HOUSES, sender, e);
		}
		
		private void HousesItemChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.HOUSES, sender, e);
		}
		
		#endregion Property Houses
		
		#region Get/Set by name and CopyFrom
		
		public object GetField(string fieldName)
		{
			switch (fieldName)
			{
				case PROPERTIES.CARS:
					return GetCars();
				case PROPERTIES.NAME:
					return GetName();
				case PROPERTIES.HOUSES:
					return GetHouses();
			}
			
			throw new ArgumentException("No gettable field named " + fieldName);
		}
		
		public void SetField(string fieldName, object value)
		{
			switch (fieldName)
			{
				case PROPERTIES.NAME:
					if (!(value is string))
						throw new ArgumentException(fieldName + " must be of type string");
						
					SetName((string) value);
					
					return;
			}
			
			throw new ArgumentException("No settable field named " + fieldName);
		}
		
		public void CopyFrom(Person other)
		{
			Cars.Clear();
			Cars.AddRange(other.Cars);
			Name = other.Name;
			Houses.Clear();
			Houses.AddRange(other.Houses);
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
		
		public Person Clone()
		{
			return (Person) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Person((Person) this);
		}
		
		#endregion
	}
	
}