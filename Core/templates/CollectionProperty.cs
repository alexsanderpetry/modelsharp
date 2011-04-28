﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace org.pescuma.ModelSharp.Core.templates
{
    using org.pescuma.ModelSharp.Core.model;
    using System;
    
    
    #line 1 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class CollectionProperty : TemplateUtils
    {
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
        public override string TransformText()
        {
            this.GenerationEnvironment = null;
            
            #line 4 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 ForEach("Annotation", it.FieldAnnotations); 
            
            #line default
            #line hidden
            
            #line 5 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.ExposeAsReadOnly) { 
            
            #line default
            #line hidden
            this.Write("\t\tprotected ");
            
            #line 6 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (!it.Lazy) { 
            
            #line default
            #line hidden
            this.Write("readonly ");
            
            #line 6 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            
            #line 6 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.TypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 6 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\t\t[DebuggerBrowsable(DebuggerBrowsableState.Never)]\r\n\t\tprivate ");
            
            #line 9 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ExposedTypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 9 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ExposedFieldName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 10 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\tprivate ");
            
            #line 11 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.ReadOnly) { 
            
            #line default
            #line hidden
            this.Write("readonly ");
            
            #line 11 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            
            #line 11 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.TypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 11 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 12 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 14 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.Documentation != null) { 
            
            #line default
            #line hidden
            this.Write("\t\t/// <summary>\r\n\t\t/// ");
            
            #line 16 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Documentation));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t/// </summary>\r\n");
            
            #line 18 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            
            #line 19 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 ForEach("Annotation", it.Annotations); 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 20 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ExposedTypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 20 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(" \r\n\t\t{\r\n");
            
            #line 22 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 ForEach("Annotation", it.PropGetAnnotations); 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 23 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.GetterVisibility != null) { 
            
            #line default
            #line hidden
            
            #line 23 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.GetterVisibility));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 23 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            this.Write("get{ return ");
            
            #line 23 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Getter.Name));
            
            #line default
            #line hidden
            this.Write("(); }\r\n\t\t}\r\n");
            
            #line 25 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.LazyInitializer != null) { 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 27 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 ForEach("Annotation", it.LazyInitializer.Annotations); 
            
            #line default
            #line hidden
            this.Write("\t\tprotected virtual ");
            
            #line 28 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.LazyInitializer.TypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 28 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.LazyInitializer.Name));
            
            #line default
            #line hidden
            this.Write("() \r\n\t\t{\r\n\t\t\tif (this.");
            
            #line 30 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t\treturn;\r\n\r\n\t\t\tthis.");
            
            #line 33 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 33 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.TypeName));
            
            #line default
            #line hidden
            this.Write("();\r\n\t\t\tAdd");
            
            #line 34 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ListListeners(this.");
            
            #line 34 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 35 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
		if (it.ExposeAsReadOnly) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\r\n\t\t\tthis.");
            
            #line 37 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ExposedFieldName));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 37 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ExposedTypeName));
            
            #line default
            #line hidden
            this.Write("(this.");
            
            #line 37 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 38 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
		} 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n");
            
            #line 40 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 42 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 ForEach("Annotation", it.Getter.Annotations); 
            
            #line default
            #line hidden
            this.Write("\t\tprotected virtual ");
            
            #line 43 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Getter.TypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 43 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Getter.Name));
            
            #line default
            #line hidden
            this.Write("()\r\n\t\t{\r\n");
            
            #line 45 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.LazyInitializer != null) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 46 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.LazyInitializer.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 47 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\treturn this.");
            
            #line 48 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ExposedFieldName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t}\r\n\r\n\t\tprivate void Add");
            
            #line 51 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ListListeners(");
            
            #line 51 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.TypeName));
            
            #line default
            #line hidden
            this.Write(@" child)
		{
			if (child == null)
				return;

			var notifyPropertyChanging = child as INotifyPropertyChanging;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyPropertyChanging != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyPropertyChanging.PropertyChanging += ");
            
            #line 60 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ListPropertyChangingEventHandler;

			var notifyPropertyChanged = child as INotifyPropertyChanged;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyPropertyChanged != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyPropertyChanged.PropertyChanged += ");
            
            #line 66 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ListPropertyChangedEventHandler;\r\n");
            
            #line 67 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.ContentsType.CanListenTo) { 
            
            #line default
            #line hidden
            this.Write(@"
			var notifyChildPropertyChanged = child as INotifyCollectionChanged;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyChildPropertyChanged != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyChildPropertyChanged.CollectionChanged += ");
            
            #line 73 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ListChangedEventHandler;\r\n\r\n\t\t\tforeach (var item in child)\r\n\t\t\t\tAdd");
            
            #line 76 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemListeners(item);\r\n");
            
            #line 77 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t\tprivate void ");
            
            #line 80 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ListPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)\r\n\t\t{" +
                    "\r\n\t\t\tif (e.PropertyName != ");
            
            #line 82 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.TypeName));
            
            #line default
            #line hidden
            this.Write(".PROPERTIES.ITEMS)\r\n\t\t\t\treturn;\r\n\r\n\t\t\tNotifyPropertyChanging(PROPERTIES.");
            
            #line 85 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.DefineName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n\r\n\t\tprivate void ");
            
            #line 88 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ListPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)\r\n\t\t{\r\n" +
                    "\t\t\tif (e.PropertyName != ");
            
            #line 90 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.TypeName));
            
            #line default
            #line hidden
            this.Write(".PROPERTIES.ITEMS)\r\n\t\t\t\treturn;\r\n\r\n\t\t\tNotifyPropertyChanged(PROPERTIES.");
            
            #line 93 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.DefineName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n");
            
            #line 95 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 if (it.ContentsType.CanListenTo) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\tprivate void ");
            
            #line 97 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ListChangedEventHandler(object sender, NotifyCollectionChangedEventArgs e)
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
							Remove");
            
            #line 111 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemListeners(item);\r\n\r\n\t\t\t\t\tif (e.NewItems != null)\r\n\t\t\t\t\t\tforeach (var item in " +
                    "e.NewItems)\r\n\t\t\t\t\t\t\tAdd");
            
            #line 115 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemListeners(item);

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

		private void Remove");
            
            #line 128 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemListeners(object child)
		{
			if (child == null)
				return;

			var notifyPropertyChanging = child as INotifyPropertyChanging;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyPropertyChanging != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyPropertyChanging.PropertyChanging -= ");
            
            #line 137 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemPropertyChangingEventHandler;

			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyChildPropertyChanging != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyChildPropertyChanging.ChildPropertyChanging -= ");
            
            #line 143 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemChildPropertyChangingEventHandler;

			var notifyPropertyChanged = child as INotifyPropertyChanged;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyPropertyChanged != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyPropertyChanged.PropertyChanged -= ");
            
            #line 149 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemPropertyChangedEventHandler;

			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyChildPropertyChanged != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyChildPropertyChanged.ChildPropertyChanged -= ");
            
            #line 155 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemChildPropertyChangedEventHandler;\r\n\t\t}\r\n\r\n\t\tprivate void Add");
            
            #line 158 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemListeners(object child)
		{
			if (child == null)
				return;

			var notifyPropertyChanging = child as INotifyPropertyChanging;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyPropertyChanging != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyPropertyChanging.PropertyChanging += ");
            
            #line 167 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemPropertyChangingEventHandler;

			var notifyChildPropertyChanging = child as INotifyChildPropertyChanging;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyChildPropertyChanging != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyChildPropertyChanging.ChildPropertyChanging += ");
            
            #line 173 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemChildPropertyChangingEventHandler;

			var notifyPropertyChanged = child as INotifyPropertyChanged;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyPropertyChanged != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyPropertyChanged.PropertyChanged += ");
            
            #line 179 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(@"ItemPropertyChangedEventHandler;

			var notifyChildPropertyChanged = child as INotifyChildPropertyChanged;
// ReSharper disable ConditionIsAlwaysTrueOrFalse
			if (notifyChildPropertyChanged != null)
// ReSharper restore ConditionIsAlwaysTrueOrFalse
				notifyChildPropertyChanged.ChildPropertyChanged += ");
            
            #line 185 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemChildPropertyChangedEventHandler;\r\n\t\t}\r\n\r\n\t\tprivate void ");
            
            #line 188 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemPropertyChangingEventHandler(object sender, PropertyChangingEventArgs e)\r\n\t\t{" +
                    "\r\n\t\t\tNotifyChildPropertyChanging(PROPERTIES.");
            
            #line 190 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.DefineName));
            
            #line default
            #line hidden
            this.Write(", sender, e);\r\n\t\t}\r\n\r\n\t\tprivate void ");
            
            #line 193 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemChildPropertyChangingEventHandler(object sender, ChildPropertyChangingEventAr" +
                    "gs e)\r\n\t\t{\r\n\t\t\tNotifyChildPropertyChanging(PROPERTIES.");
            
            #line 195 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.DefineName));
            
            #line default
            #line hidden
            this.Write(", sender, e);\r\n\t\t}\r\n\r\n\t\tprivate void ");
            
            #line 198 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)\r\n\t\t{\r\n" +
                    "\t\t\tNotifyChildPropertyChanged(PROPERTIES.");
            
            #line 200 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.DefineName));
            
            #line default
            #line hidden
            this.Write(", sender, e);\r\n\t\t}\r\n\r\n\t\tprivate void ");
            
            #line 203 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("ItemChildPropertyChangedEventHandler(object sender, ChildPropertyChangedEventArgs" +
                    " e)\r\n\t\t{\r\n\t\t\tNotifyChildPropertyChanged(PROPERTIES.");
            
            #line 205 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.DefineName));
            
            #line default
            #line hidden
            this.Write(", sender, e);\r\n\t\t}\r\n");
            
            #line 207 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "X:\c#\modelsharp\Core\templates\CollectionProperty.tt"

private global::org.pescuma.ModelSharp.Core.model.CollectionInfo _itField;

/// <summary>
/// Access the it parameter of the template.
/// </summary>
private global::org.pescuma.ModelSharp.Core.model.CollectionInfo it
{
    get
    {
        return this._itField;
    }
}


public override void Initialize()
{
    base.Initialize();
    if ((this.Errors.HasErrors == false))
    {
bool itValueAcquired = false;
if (this.Session.ContainsKey("it"))
{
    if ((typeof(global::org.pescuma.ModelSharp.Core.model.CollectionInfo).IsAssignableFrom(this.Session["it"].GetType()) == false))
    {
        this.Error("The type \'org.pescuma.ModelSharp.Core.model.CollectionInfo\' of the parameter \'it\'" +
                " did not match the type of the data passed to the template.");
    }
    else
    {
        this._itField = ((global::org.pescuma.ModelSharp.Core.model.CollectionInfo)(this.Session["it"]));
        itValueAcquired = true;
    }
}
if ((itValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("it");
    if ((data != null))
    {
        if ((typeof(global::org.pescuma.ModelSharp.Core.model.CollectionInfo).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'org.pescuma.ModelSharp.Core.model.CollectionInfo\' of the parameter \'it\'" +
                    " did not match the type of the data passed to the template.");
        }
        else
        {
            this._itField = ((global::org.pescuma.ModelSharp.Core.model.CollectionInfo)(data));
        }
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
