// Automatically generated by Model#
// DO NOT EDIT THIS FILE

using org.pescuma.ModelSharp.Lib;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Diagnostics;

namespace examples.doc
{

	/// <summary>
	/// A point, man!
	/// </summary>
	[DataContract]
	[DebuggerDisplay("Point[X={X} Ws={Ws.Count}items]")]
	public abstract class BasePoint : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, IDeserializationCallback, ICloneable
	{
		#region Field Name Defines
		
		public class PROPERTIES
		{
			public const string X = "X";
			public const string Y = "Y";
			public const string LEN = "Len";
			public const string WS = "Ws";
		}
		
		#endregion
		
		#region Constructors
		
		public BasePoint()
		{
			this.y = new Point();
			AddYListeners(this.y);
			this.ws = new ObservableList<double>();
			AddWsListListeners(this.ws);
		}
		
		public BasePoint(BasePoint other)
		{
			this.x = other.X;
			this.y = new Point(other.Y);
			AddYListeners(this.y);
			this.ws = new ObservableList<double>();
			this.ws.AddRange(other.Ws);
			AddWsListListeners(this.ws);
		}
		
		#endregion
		
		#region Property X
		
		[DataMember(Name = "X", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double x;
		
		/// <summary>
		/// The X cartesian coord
		/// </summary>
		public double X
		{
			[DebuggerStepThrough]
			get {
				return GetX();
			}
			[DebuggerStepThrough]
			set {
				SetX(value);
			}
		}
		
		protected virtual double GetX()
		{
			return this.x;
		}
		
		protected virtual bool SetX(double x)
		{
			if (this.x == x)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.X);
			
			this.x = x;
			
			NotifyPropertyChanged(PROPERTIES.X);
			
			return true;
		}
		
		#endregion Property X
		
		#region Property Y
		
		[DataMember(Name = "Y", Order = 1, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Point y;
		
		/// <summary>
		/// Y, oh Y
		/// </summary>
		public Point Y
		{
			[DebuggerStepThrough]
			get {
				return GetY();
			}
		}
		
		protected virtual Point GetY()
		{
			return this.y;
		}
		
		private void AddYListeners(object child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += YPropertyChangingEventHandler;
				
			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
			if (notifyChildPropertyChanging != null)
				notifyChildPropertyChanging.ChildPropertyChanging += YChildPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += YPropertyChangedEventHandler;
				
			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
			if (notifyChildPropertyChanged != null)
				notifyChildPropertyChanged.ChildPropertyChanged += YChildPropertyChangedEventHandler;
		}
		
		private void YPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.Y, sender, e);
		}
		
		private void YChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventArgs e)
		{
			NotifyChildPropertyChanging(PROPERTIES.Y, sender, e);
		}
		
		private void YPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.Y, sender, e);
		}
		
		private void YChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs e)
		{
			NotifyChildPropertyChanged(PROPERTIES.Y, sender, e);
		}
		
		#endregion Property Y
		
		#region Property Len
		
		/// <summary>
		/// x*x + y*Y sqrt
		/// </summary>
		public double Len
		{
			[DebuggerStepThrough]
			get {
				return ComputeLen();
			}
		}
		
		protected abstract double ComputeLen();
		
		#endregion Property Len
		
		#region Property Ws
		
		[DataMember(Name = "Ws", Order = 2, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ObservableList<double> ws;
		
		/// <summary>
		/// All the ws you can find
		/// </summary>
		public ObservableList<double> Ws
		{
			[DebuggerStepThrough]
			get {
				return GetWs();
			}
		}
		
		protected virtual ObservableList<double> GetWs()
		{
			return this.ws;
		}
		
		private void AddWsListListeners(ObservableList<double> child)
		{
			if (child == null)
				return;
				
			var notifyPropertyChanging = child as INotifyPropertyChanging;
			if (notifyPropertyChanging != null)
				notifyPropertyChanging.PropertyChanging += WsListPropertyChangingEventHandler;
				
			var notifyPropertyChanged = child as INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
				notifyPropertyChanged.PropertyChanged += WsListPropertyChangedEventHandler;
		}
		
		private void WsListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)
		{
			if (e.PropertyName != ObservableList<double>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanging(PROPERTIES.WS);
		}
		
		private void WsListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName != ObservableList<double>.PROPERTIES.ITEMS)
				return;
				
			NotifyPropertyChanged(PROPERTIES.WS);
		}
		
		#endregion Property Ws
		
		public virtual void CopyFrom(Point other)
		{
			X = other.X;
			Y.CopyFrom(other.Y);
			Ws.Clear();
			Ws.AddRange(other.Ws);
		}
		
		#region Property Notification
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		protected virtual void NotifyPropertyChanging(string propertyName)
		{
			PropertyChangingEventHandler handler = PropertyChanging;
			if (handler != null)
				handler(this, new PropertyChangingEventArgs(propertyName));
				
			NotifyPropertyChanging(PROPERTIES.LEN);
		}
		
		public event ChildPropertyChangingEventHandler ChildPropertyChanging;
		
		protected virtual void NotifyChildPropertyChanging(string propertyName, object sender, PropertyChangingEventArgs e)
		{
			ChildPropertyChangingEventHandler handler = ChildPropertyChanging;
			if (handler != null)
				handler(sender, new ChildPropertyChangingEventArgs(this, propertyName, sender, e));
				
			NotifyPropertyChanging(PROPERTIES.LEN);
		}
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void NotifyPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
				
			NotifyPropertyChanged(PROPERTIES.LEN);
		}
		
		public event ChildPropertyChangedEventHandler ChildPropertyChanged;
		
		protected virtual void NotifyChildPropertyChanged(string propertyName, object sender, PropertyChangedEventArgs e)
		{
			ChildPropertyChangedEventHandler handler = ChildPropertyChanged;
			if (handler != null)
				handler(sender, new ChildPropertyChangedEventArgs(this, propertyName, sender, e));
				
			NotifyPropertyChanged(PROPERTIES.LEN);
		}
		
		#endregion
		
		#region Clone
		
#pragma warning disable 109
		public new Point Clone()
#pragma warning restore 109
		{
			return (Point) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Point((Point) this);
		}
		
		#endregion
		
		#region Serialization
		
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			AddYListeners(this.y);
			AddWsListListeners(this.ws);
		}
		
		#endregion
	}
	
}
