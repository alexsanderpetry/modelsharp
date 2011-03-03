// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using org.pescuma.ModelSharp.Lib;
using System.Collections.Specialized;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.collectionReadOnly
{

	[DataContract]
	[DebuggerDisplay("Person[Houses={Houses.Count}items]")]
	public abstract class BasePerson : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string HOUSES = "Houses";
		}
		
		#endregion
		
		#region Constructors
		
		public BasePerson()
		{
			this._houses = new ObservableList<House>();
			AddHousesListListeners(this._houses);
		}
		
		public BasePerson(BasePerson other)
		{
			this._houses = new ObservableList<House>();
			AddHousesListListeners(this._houses);
			this._houses.AddRange(other.Houses);
		}
		
		#endregion
		
		#region Property Houses
		
		[DataMember(Name = "Houses", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		protected readonly ObservableList<House> _houses;
		
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ReadOnlyObservableList<House> _housesReadOnly;
		
		public ReadOnlyObservableList<House> Houses
		{
			[DebuggerStepThrough]
			get {
				return GetHouses();
			}
		}
		
		protected virtual void LazyInitHousesReadOnly()
		{
			if (this._housesReadOnly != null)
				return;
				
			this._housesReadOnly = new ReadOnlyObservableList<House>(this._houses);
		}
		
		protected virtual ReadOnlyObservableList<House> GetHouses()
		{
			LazyInitHousesReadOnly();
			return this._housesReadOnly;
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
		
		public virtual void CopyFrom(Person other)
		{
			this._houses.Clear();
			this._houses.AddRange(other.Houses);
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
		public new Person Clone()
#pragma warning restore 109
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
