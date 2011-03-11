// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using System.Collections.Generic;
using System.Collections;
using org.pescuma.ModelSharp.Lib;
using System.Collections.Specialized;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.deepCopy
{

	[DataContract]
	[DebuggerDisplay("Person[HomeAddressCol={HomeAddressCol.Count}items WorkAddressCol={WorkAddressCol.Count}items LazyAddressCol={LazyAddressCol.Count}items StringCol={StringCol.Count}items StringCol2={StringCol2.Count}items DoubleCol={DoubleCol.Count}items DoubleCol2={DoubleCol2.Count}items HomeAddressProp={HomeAddressProp} WorkAddressProp={WorkAddressProp}]")]
	public abstract class BasePerson : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, IDeserializationCallback, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string HOME_ADDRESS_COL = "HomeAddressCol";
			public const string WORK_ADDRESS_COL = "WorkAddressCol";
			public const string LAZY_ADDRESS_COL = "LazyAddressCol";
			public const string STRING_COL = "StringCol";
			public const string STRING_COL2 = "StringCol2";
			public const string DOUBLE_COL = "DoubleCol";
			public const string DOUBLE_COL2 = "DoubleCol2";
			public const string HOME_ADDRESS_PROP = "HomeAddressProp";
			public const string WORK_ADDRESS_PROP = "WorkAddressProp";
		}
		
		#endregion
		
		#region Constructors
		
		public BasePerson()
		{
			this.homeAddressCol = new ObservableList<Address>();
			AddHomeAddressColListListeners(this.homeAddressCol);
			this.workAddressCol = new ObservableList<Address>();
			AddWorkAddressColListListeners(this.workAddressCol);
			this.stringCol = new ObservableList<string>();
			AddStringColListListeners(this.stringCol);
			this.stringCol2 = new ObservableList<string>();
			AddStringCol2ListListeners(this.stringCol2);
			this.doubleCol = new ObservableList<double>();
			AddDoubleColListListeners(this.doubleCol);
			this.doubleCol2 = new ObservableList<double>();
			AddDoubleCol2ListListeners(this.doubleCol2);
			AddHomeAddressPropListeners(this.homeAddressProp);
			AddWorkAddressPropListeners(this.workAddressProp);
		}
		
		public BasePerson(BasePerson other)
		{
			this.homeAddressCol = new ObservableList<Address>();
			foreach (Address otherItem in other.HomeAddressCol)
				this.homeAddressCol.Add(otherItem == null ? null : new Address(otherItem));
			AddHomeAddressColListListeners(this.homeAddressCol);
			this.workAddressCol = new ObservableList<Address>();
			this.workAddressCol.AddRange(other.WorkAddressCol);
			AddWorkAddressColListListeners(this.workAddressCol);
			if (other.lazyAddressCol != null)
			{
				this.lazyAddressCol = new ObservableList<Address>();
				foreach (Address otherItem in other.LazyAddressCol)
					this.lazyAddressCol.Add(otherItem == null ? null : new Address(otherItem));
				AddLazyAddressColListListeners(this.lazyAddressCol);
			}
			this.stringCol = new ObservableList<string>();
			foreach (string otherItem in other.StringCol)
				this.stringCol.Add(otherItem == null ? null : string.Copy(otherItem));
			AddStringColListListeners(this.stringCol);
			this.stringCol2 = new ObservableList<string>();
			this.stringCol2.AddRange(other.StringCol2);
			AddStringCol2ListListeners(this.stringCol2);
			this.doubleCol = new ObservableList<double>();
			this.doubleCol.AddRange(other.DoubleCol);
			AddDoubleColListListeners(this.doubleCol);
			this.doubleCol2 = new ObservableList<double>();
			this.doubleCol2.AddRange(other.DoubleCol2);
			AddDoubleCol2ListListeners(this.doubleCol2);
			if (other.HomeAddressProp == null)
				this.homeAddressProp = null;
			else
				this.homeAddressProp = new Address(other.HomeAddressProp);
			AddHomeAddressPropListeners(this.homeAddressProp);
			this.workAddressProp = other.WorkAddressProp;
			AddWorkAddressPropListeners(this.workAddressProp);
		}
		
		#endregion
		
		#region Property HomeAddressCol
		
		[DataMember(Name = "HomeAddressCol", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<Address> homeAddressCol;
		
		public ObservableList<Address> HomeAddressCol
		{
			[DebuggerStepThrough]
			get {
				return GetHomeAddressCol();
			}
		}
		
		protected virtual ObservableList<Address> GetHomeAddressCol()
		{
			return this.homeAddressCol;
		}
		
		private void AddHomeAddressColListListeners(ObservableList<Address> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += HomeAddressColListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += HomeAddressColListPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyCollectionChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.CollectionChanged += HomeAddressColListChangedEventHandler;
				
			foreach (var item in child)
				AddHomeAddressColItemListeners(item);
		}
		
		private void HomeAddressColListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<Address>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.HOME_ADDRESS_COL);
		}
		
		private void HomeAddressColListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<Address>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.HOME_ADDRESS_COL);
		}
		
		private void HomeAddressColListChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e)
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
							RemoveHomeAddressColItemListeners(item);
							
					if (e.NewItems != null)
						foreach (var item in e.NewItems)
							AddHomeAddressColItemListeners(item);
							
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
		
		private void RemoveHomeAddressColItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= HomeAddressColItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= HomeAddressColItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= HomeAddressColItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= HomeAddressColItemChildPropertyChangedEventHandler;
		}
		
		private void AddHomeAddressColItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += HomeAddressColItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += HomeAddressColItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += HomeAddressColItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += HomeAddressColItemChildPropertyChangedEventHandler;
		}
		
		private void HomeAddressColItemPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.HOME_ADDRESS_COL, sender, e);
		}
		
		private void HomeAddressColItemChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.HOME_ADDRESS_COL, sender, e);
		}
		
		private void HomeAddressColItemPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.HOME_ADDRESS_COL, sender, e);
		}
		
		private void HomeAddressColItemChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.HOME_ADDRESS_COL, sender, e);
		}
		
		#endregion Property HomeAddressCol
		
		#region Property WorkAddressCol
		
		[DataMember(Name = "WorkAddressCol", Order = 1, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<Address> workAddressCol;
		
		public ObservableList<Address> WorkAddressCol
		{
			[DebuggerStepThrough]
			get {
				return GetWorkAddressCol();
			}
		}
		
		protected virtual ObservableList<Address> GetWorkAddressCol()
		{
			return this.workAddressCol;
		}
		
		private void AddWorkAddressColListListeners(ObservableList<Address> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += WorkAddressColListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += WorkAddressColListPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyCollectionChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.CollectionChanged += WorkAddressColListChangedEventHandler;
				
			foreach (var item in child)
				AddWorkAddressColItemListeners(item);
		}
		
		private void WorkAddressColListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<Address>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.WORK_ADDRESS_COL);
		}
		
		private void WorkAddressColListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<Address>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.WORK_ADDRESS_COL);
		}
		
		private void WorkAddressColListChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e)
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
							RemoveWorkAddressColItemListeners(item);
							
					if (e.NewItems != null)
						foreach (var item in e.NewItems)
							AddWorkAddressColItemListeners(item);
							
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
		
		private void RemoveWorkAddressColItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= WorkAddressColItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= WorkAddressColItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= WorkAddressColItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= WorkAddressColItemChildPropertyChangedEventHandler;
		}
		
		private void AddWorkAddressColItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += WorkAddressColItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += WorkAddressColItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += WorkAddressColItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += WorkAddressColItemChildPropertyChangedEventHandler;
		}
		
		private void WorkAddressColItemPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.WORK_ADDRESS_COL, sender, e);
		}
		
		private void WorkAddressColItemChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.WORK_ADDRESS_COL, sender, e);
		}
		
		private void WorkAddressColItemPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.WORK_ADDRESS_COL, sender, e);
		}
		
		private void WorkAddressColItemChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.WORK_ADDRESS_COL, sender, e);
		}
		
		#endregion Property WorkAddressCol
		
		#region Property LazyAddressCol
		
		[DataMember(Name = "LazyAddressCol", Order = 2, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ObservableList<Address> lazyAddressCol;
		
		public ObservableList<Address> LazyAddressCol
		{
			[DebuggerStepThrough]
			get {
				return GetLazyAddressCol();
			}
		}
		
		protected virtual void LazyInitLazyAddressCol()
		{
			if (this.lazyAddressCol != null)
				return;
				
			this.lazyAddressCol = new ObservableList<Address>();
			AddLazyAddressColListListeners(this.lazyAddressCol);
		}
		
		protected virtual ObservableList<Address> GetLazyAddressCol()
		{
			LazyInitLazyAddressCol();
			return this.lazyAddressCol;
		}
		
		private void AddLazyAddressColListListeners(ObservableList<Address> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += LazyAddressColListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += LazyAddressColListPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyCollectionChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.CollectionChanged += LazyAddressColListChangedEventHandler;
				
			foreach (var item in child)
				AddLazyAddressColItemListeners(item);
		}
		
		private void LazyAddressColListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<Address>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.LAZY_ADDRESS_COL);
		}
		
		private void LazyAddressColListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<Address>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.LAZY_ADDRESS_COL);
		}
		
		private void LazyAddressColListChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e)
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
							RemoveLazyAddressColItemListeners(item);
							
					if (e.NewItems != null)
						foreach (var item in e.NewItems)
							AddLazyAddressColItemListeners(item);
							
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
		
		private void RemoveLazyAddressColItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= LazyAddressColItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= LazyAddressColItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= LazyAddressColItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= LazyAddressColItemChildPropertyChangedEventHandler;
		}
		
		private void AddLazyAddressColItemListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += LazyAddressColItemPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += LazyAddressColItemChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += LazyAddressColItemPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += LazyAddressColItemChildPropertyChangedEventHandler;
		}
		
		private void LazyAddressColItemPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.LAZY_ADDRESS_COL, sender, e);
		}
		
		private void LazyAddressColItemChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.LAZY_ADDRESS_COL, sender, e);
		}
		
		private void LazyAddressColItemPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.LAZY_ADDRESS_COL, sender, e);
		}
		
		private void LazyAddressColItemChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.LAZY_ADDRESS_COL, sender, e);
		}
		
		#endregion Property LazyAddressCol
		
		#region Property StringCol
		
		[DataMember(Name = "StringCol", Order = 3, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<string> stringCol;
		
		public ObservableList<string> StringCol
		{
			[DebuggerStepThrough]
			get {
				return GetStringCol();
			}
		}
		
		protected virtual ObservableList<string> GetStringCol()
		{
			return this.stringCol;
		}
		
		private void AddStringColListListeners(ObservableList<string> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += StringColListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += StringColListPropertyChangedEventHandler;
		}
		
		private void StringColListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<string>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.STRING_COL);
		}
		
		private void StringColListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<string>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.STRING_COL);
		}
		
		#endregion Property StringCol
		
		#region Property StringCol2
		
		[DataMember(Name = "StringCol2", Order = 4, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<string> stringCol2;
		
		public ObservableList<string> StringCol2
		{
			[DebuggerStepThrough]
			get {
				return GetStringCol2();
			}
		}
		
		protected virtual ObservableList<string> GetStringCol2()
		{
			return this.stringCol2;
		}
		
		private void AddStringCol2ListListeners(ObservableList<string> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += StringCol2ListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += StringCol2ListPropertyChangedEventHandler;
		}
		
		private void StringCol2ListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<string>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.STRING_COL2);
		}
		
		private void StringCol2ListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<string>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.STRING_COL2);
		}
		
		#endregion Property StringCol2
		
		#region Property DoubleCol
		
		[DataMember(Name = "DoubleCol", Order = 5, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<double> doubleCol;
		
		public ObservableList<double> DoubleCol
		{
			[DebuggerStepThrough]
			get {
				return GetDoubleCol();
			}
		}
		
		protected virtual ObservableList<double> GetDoubleCol()
		{
			return this.doubleCol;
		}
		
		private void AddDoubleColListListeners(ObservableList<double> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += DoubleColListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += DoubleColListPropertyChangedEventHandler;
		}
		
		private void DoubleColListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<double>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.DOUBLE_COL);
		}
		
		private void DoubleColListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<double>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.DOUBLE_COL);
		}
		
		#endregion Property DoubleCol
		
		#region Property DoubleCol2
		
		[DataMember(Name = "DoubleCol2", Order = 6, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<double> doubleCol2;
		
		public ObservableList<double> DoubleCol2
		{
			[DebuggerStepThrough]
			get {
				return GetDoubleCol2();
			}
		}
		
		protected virtual ObservableList<double> GetDoubleCol2()
		{
			return this.doubleCol2;
		}
		
		private void AddDoubleCol2ListListeners(ObservableList<double> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += DoubleCol2ListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += DoubleCol2ListPropertyChangedEventHandler;
		}
		
		private void DoubleCol2ListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<double>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.DOUBLE_COL2);
		}
		
		private void DoubleCol2ListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<double>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.DOUBLE_COL2);
		}
		
		#endregion Property DoubleCol2
		
		#region Property HomeAddressProp
		
		[DataMember(Name = "HomeAddressProp", Order = 7, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Address homeAddressProp;
		
		public Address HomeAddressProp
		{
			[DebuggerStepThrough]
			get {
				return GetHomeAddressProp();
			}
			[DebuggerStepThrough]
			set {
				SetHomeAddressProp(value);
			}
		}
		
		protected virtual Address GetHomeAddressProp()
		{
			return this.homeAddressProp;
		}
		
		protected virtual bool SetHomeAddressProp(Address homeAddressProp)
		{
			if (this.homeAddressProp == homeAddressProp)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.HOME_ADDRESS_PROP);
			
			RemoveHomeAddressPropListeners(homeAddressProp);
			
			this.homeAddressProp = homeAddressProp;
			
			AddHomeAddressPropListeners(homeAddressProp);
			
			NotifyPropertyChanged(PROPERTIES.HOME_ADDRESS_PROP);
			
			return true;
		}
		
		private void RemoveHomeAddressPropListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= HomeAddressPropPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= HomeAddressPropChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= HomeAddressPropPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= HomeAddressPropChildPropertyChangedEventHandler;
		}
		
		private void AddHomeAddressPropListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += HomeAddressPropPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += HomeAddressPropChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += HomeAddressPropPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += HomeAddressPropChildPropertyChangedEventHandler;
		}
		
		private void HomeAddressPropPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.HOME_ADDRESS_PROP, sender, e);
		}
		
		private void HomeAddressPropChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.HOME_ADDRESS_PROP, sender, e);
		}
		
		private void HomeAddressPropPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.HOME_ADDRESS_PROP, sender, e);
		}
		
		private void HomeAddressPropChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.HOME_ADDRESS_PROP, sender, e);
		}
		
		#endregion Property HomeAddressProp
		
		#region Property WorkAddressProp
		
		[DataMember(Name = "WorkAddressProp", Order = 8, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Address workAddressProp;
		
		public Address WorkAddressProp
		{
			[DebuggerStepThrough]
			get {
				return GetWorkAddressProp();
			}
			[DebuggerStepThrough]
			set {
				SetWorkAddressProp(value);
			}
		}
		
		protected virtual Address GetWorkAddressProp()
		{
			return this.workAddressProp;
		}
		
		protected virtual bool SetWorkAddressProp(Address workAddressProp)
		{
			if (this.workAddressProp == workAddressProp)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.WORK_ADDRESS_PROP);
			
			RemoveWorkAddressPropListeners(workAddressProp);
			
			this.workAddressProp = workAddressProp;
			
			AddWorkAddressPropListeners(workAddressProp);
			
			NotifyPropertyChanged(PROPERTIES.WORK_ADDRESS_PROP);
			
			return true;
		}
		
		private void RemoveWorkAddressPropListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging -= WorkAddressPropPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging -= WorkAddressPropChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged -= WorkAddressPropPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged -= WorkAddressPropChildPropertyChangedEventHandler;
		}
		
		private void AddWorkAddressPropListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += WorkAddressPropPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += WorkAddressPropChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += WorkAddressPropPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += WorkAddressPropChildPropertyChangedEventHandler;
		}
		
		private void WorkAddressPropPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.WORK_ADDRESS_PROP, sender, e);
		}
		
		private void WorkAddressPropChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.WORK_ADDRESS_PROP, sender, e);
		}
		
		private void WorkAddressPropPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.WORK_ADDRESS_PROP, sender, e);
		}
		
		private void WorkAddressPropChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.WORK_ADDRESS_PROP, sender, e);
		}
		
		#endregion Property WorkAddressProp
		
		public virtual void CopyFrom(Person other)
		{
			HomeAddressCol.Clear();
			foreach (Address otherItem in other.HomeAddressCol)
				HomeAddressCol.Add(otherItem == null ? null : new Address(otherItem));
			WorkAddressCol.Clear();
			WorkAddressCol.AddRange(other.WorkAddressCol);
			if (other.lazyAddressCol != null)
			{
				LazyAddressCol.Clear();
				foreach (Address otherItem in other.LazyAddressCol)
					LazyAddressCol.Add(otherItem == null ? null : new Address(otherItem));
			}
			else
			{
				if (this.lazyAddressCol != null)
					this.lazyAddressCol.Clear();
			}
			StringCol.Clear();
			foreach (string otherItem in other.StringCol)
				StringCol.Add(otherItem == null ? null : string.Copy(otherItem));
			StringCol2.Clear();
			StringCol2.AddRange(other.StringCol2);
			DoubleCol.Clear();
			DoubleCol.AddRange(other.DoubleCol);
			DoubleCol2.Clear();
			DoubleCol2.AddRange(other.DoubleCol2);
			if (other.HomeAddressProp == null)
				HomeAddressProp = null;
			else
				HomeAddressProp = new Address(other.HomeAddressProp);
			WorkAddressProp = other.WorkAddressProp;
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
		
		#region Serialization
		
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			AddHomeAddressColListListeners(this.homeAddressCol);
			AddWorkAddressColListListeners(this.workAddressCol);
			AddLazyAddressColListListeners(this.lazyAddressCol);
			AddStringColListListeners(this.stringCol);
			AddStringCol2ListListeners(this.stringCol2);
			AddDoubleColListListeners(this.doubleCol);
			AddDoubleCol2ListListeners(this.doubleCol2);
			AddHomeAddressPropListeners(this.homeAddressProp);
			AddWorkAddressPropListeners(this.workAddressProp);
		}
		
		#endregion
	}
	
}
