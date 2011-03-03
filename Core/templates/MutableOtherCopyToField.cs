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
    
    
    #line 1 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class MutableOtherCopyToField : TemplateUtils
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
            
            #line 4 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 if (it.LazyInitializer != null) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tif (other.");
            
            #line 5 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(" != null) \r\n\t\t\t{\r\n");
            
            #line 7 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 } 
            
            #line default
            #line hidden
            
            #line 8 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 if (it is CollectionInfo) { 
	var col = (CollectionInfo) it; 
	var target = (col.ExposeAsReadOnly ? "this." + col.FieldName : col.Name);
	
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 12 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(target));
            
            #line default
            #line hidden
            this.Write(".Clear();\r\n");
            
            #line 13 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
	Include("CopyList", col, "target", target); 
            
            #line default
            #line hidden
            
            #line 14 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 } else if (it.IsComponent) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 15 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(".CopyFrom(other.");
            
            #line 15 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 16 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 } else if (it.IsComputedAndCached) {
		var computed = (ComputedPropertyInfo) it; 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 18 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(computed.ValidFieldName));
            
            #line default
            #line hidden
            this.Write(" = false;\r\n");
            
            #line 19 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 } else { 
            
            #line default
            #line hidden
            
            #line 20 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
	Include("CopyProperty", it, "target", it.Name); 
            
            #line default
            #line hidden
            
            #line 21 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 } 
            
            #line default
            #line hidden
            
            #line 22 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 if (it.LazyInitializer != null) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t}\r\n\t\t\telse\r\n\t\t\t{\r\n");
            
            #line 26 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
		if (it.IsCollection) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\tif (this.");
            
            #line 27 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t\t\t");
            
            #line 28 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(".Clear();\r\n");
            
            #line 29 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
		} else if (it.IsComponent) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\tif (this.");
            
            #line 30 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t\t\tthis.");
            
            #line 31 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.FieldName));
            
            #line default
            #line hidden
            this.Write(".CopyFrom(new ");
            
            #line 31 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.TypeName));
            
            #line default
            #line hidden
            this.Write("());\r\n");
            
            #line 32 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
		} 
            
            #line default
            #line hidden
            this.Write("\t\t\t}\r\n");
            
            #line 34 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "X:\c#\modelsharp\Core\templates\MutableOtherCopyToField.tt"

private global::org.pescuma.ModelSharp.Core.model.PropertyInfo _itField;

/// <summary>
/// Access the it parameter of the template.
/// </summary>
private global::org.pescuma.ModelSharp.Core.model.PropertyInfo it
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
    if ((typeof(global::org.pescuma.ModelSharp.Core.model.PropertyInfo).IsAssignableFrom(this.Session["it"].GetType()) == false))
    {
        this.Error("The type \'org.pescuma.ModelSharp.Core.model.PropertyInfo\' of the parameter \'it\' d" +
                "id not match the type of the data passed to the template.");
    }
    else
    {
        this._itField = ((global::org.pescuma.ModelSharp.Core.model.PropertyInfo)(this.Session["it"]));
        itValueAcquired = true;
    }
}
if ((itValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("it");
    if ((data != null))
    {
        if ((typeof(global::org.pescuma.ModelSharp.Core.model.PropertyInfo).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'org.pescuma.ModelSharp.Core.model.PropertyInfo\' of the parameter \'it\' d" +
                    "id not match the type of the data passed to the template.");
        }
        else
        {
            this._itField = ((global::org.pescuma.ModelSharp.Core.model.PropertyInfo)(data));
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
