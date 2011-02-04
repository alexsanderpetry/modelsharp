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
	public abstract class BasePoint : INotifyPropertyChanging, INotifyChildPropertyChanging, INotifyPropertyChanged, INotifyChildPropertyChanged, ICloneable
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
			_y = 2;
			_ws = new ObservableList<double>();
			AddWsListListeners(_ws);
		}
		
		public BasePoint(BasePoint other)
		{
			_x = other.X;
			_y = new double(other.Y);
			_ws = new ObservableList<double>(other.Ws);
			AddWsListListeners(_ws);
		}
		
		#endregion
		
		#region Property X
		
		[DataMember(Name = "X", Order = 0, IsRequired = false)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double _x;
		
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
			return _x;
		}
		
		protected virtual bool SetX(double x)
		{
			if (_x == x)
				return false;
				
			NotifyPropertyChanging(PROPERTIES.X);
			
			_x = x;
			
			NotifyPropertyChanged(PROPERTIES.X);
			
			return true;
		}
		
		#endregion Property X
		
		#region Property Y
		
		[DataMember(Name = "Y", Order = 1, IsRequired = true)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly double _y;
		
		/// <summary>
		/// Y, oh Y
		/// </summary>
		public double Y
		{
			[DebuggerStepThrough]
			get {
				return GetY();
			}
		}
		
		protected virtual double GetY()
		{
			return _y;
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
		private readonly ObservableList<double> _ws;
		
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
			return _ws;
		}
		
		private void AddWsListListeners(object child)
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
		
		public Point Clone()
		{
			return (Point) ((ICloneable) this).Clone();
		}
		
		object ICloneable.Clone()
		{
			return new Point((Point) this);
		}
		
		#endregion
	}
	
}
