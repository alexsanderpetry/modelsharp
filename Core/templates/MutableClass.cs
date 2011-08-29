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
    
    
    #line 1 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class MutableClass : TemplateUtils
    {
		#region ToString Helpers
		/// <summary>
		/// Utility class to produce culture-oriented representation of an object as a string.
		/// </summary>
		public class ToStringInstanceHelper
		{
			private System.IFormatProvider formatProviderField = global::System.Globalization.CultureInfo.InvariantCulture;
			/// <summary>
			/// Gets or sets format provider to be used by ToStringWithCulture method.
			/// </summary>
			public System.IFormatProvider FormatProvider
			{
				get
				{
					return this.formatProviderField;
				}
				set
				{
					if ((value != null))
					{
						this.formatProviderField = value;
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

            this.Write("//----------------------\r\n// <auto-generated>\r\n//     Automatically generated by " +
                    "Model#\r\n// </auto-generated>\r\n//----------------------\r\n// DO NOT EDIT THIS FILE" +
                    "\r\n\r\nusing System.CodeDom.Compiler;\r\n");
            
            #line 12 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	ForEach("CreateUsing", it.Using); 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 14 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.Package != null) { 
            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 15 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Package));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\r\n");
            
            #line 18 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            
            #line 19 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.Documentation != null) { 
            
            #line default
            #line hidden
            this.Write("\t/// <summary>\r\n\t/// ");
            
            #line 21 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Documentation));
            
            #line default
            #line hidden
            this.Write("\r\n\t/// </summary>\r\n");
            
            #line 23 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            
            #line 24 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	ForEach("Annotation", it.Annotations); 
            
            #line default
            #line hidden
            
            #line 25 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	ForEach("Annotation", it.BaseOnlyAnnotations); 
            
            #line default
            #line hidden
            this.Write("\t[GeneratedCode(\"Model#\", \"");
            
            #line 26 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\tpublic abstract class ");
            
            #line 27 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 27 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 if (it.ExtendsOrImplements.Count > 0) { 
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 27 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 ForEach(it.ExtendsOrImplements, separator: ", "); 
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 27 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n\t{\r\n\t\t#region Field Name Defines\r\n\r\n");
            
            #line 31 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 if (it.BaseClass.HasProperties) { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic new class PROPERTIES : ");
            
            #line 32 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Extends));
            
            #line default
            #line hidden
            this.Write(".PROPERTIES\r\n");
            
            #line 33 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic class PROPERTIES\r\n");
            
            #line 35 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t{\r\n");
            
            #line 37 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 ForEach("Define", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tprotected PROPERTIES() {}\r\n\t\t}\r\n\r\n\t\t#endregion\r\n\r\n\t\t#region Constructors\r\n\r\n" +
                    "\t\tprotected ");
            
            #line 46 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 46 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 ForEach("Param", it.ConstructorArguments, separator: ", "); 
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n");
            
            #line 48 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	ForEach("MutableInitField", it.NonConstructorArgumentsNorComputedProperties); 
            
            #line default
            #line hidden
            
            #line 49 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	ForEach("MutableParamToField", it.ConstructorArguments); 
            
            #line default
            #line hidden
            
            #line 50 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	ForEach("ValidateIfRequiredInConstructor", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 53 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.Cloneable) { 
            
            #line default
            #line hidden
            this.Write("\t\tprotected ");
            
            #line 54 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 54 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write(" other)\r\n");
            
            #line 55 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
		if (it.Extends != null) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t: base(other)\r\n");
            
            #line 57 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
		} 
            
            #line default
            #line hidden
            this.Write("\t\t{\r\n");
            
            #line 59 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 		ForEach("MutableOtherToField", it.NonComputedProperties); 
            
            #line default
            #line hidden
            
            #line 60 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 		ForEach("ValidateIfRequiredInConstructor", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 63 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            this.Write("\t\t#endregion Constructors\r\n\r\n");
            
            #line 66 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	ForEach("Property", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t#region Property Notification\r\n\r\n");
            
            #line 69 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	Include("NotifyPropertyChange", it, "type", "Changing"); 
            
            #line default
            #line hidden
            
            #line 70 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	Include("NotifyPropertyChange", it, "type", "Changed"); 
            
            #line default
            #line hidden
            this.Write("\t\t#endregion Property Notification\r\n");
            
            #line 72 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.Cloneable) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t#region CopyFrom\r\n\r\n\t\tvoid ICopyable.CopyFrom(object other)\r\n\t\t{\r\n\t\t\tCopyFrom" +
                    "((");
            
            #line 78 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(") other);\r\n\t\t}\r\n\r\n\t\tpublic virtual void CopyFrom(");
            
            #line 81 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(" other)\r\n\t\t{\r\n");
            
            #line 83 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	// ForEach("ValidateIfRequiredInCopyFrom", it.Properties); 
            
            #line default
            #line hidden
            
            #line 84 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 		if (it.BaseClass.HasCopyFrom) { 
            
            #line default
            #line hidden
            this.Write("\t\t\tbase.CopyFrom(other);\r\n");
            
            #line 86 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 		} 
            
            #line default
            #line hidden
            
            #line 87 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 		ForEach("MutableOtherCopyToField", it.NonComputedProperties); 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t\t#endregion CopyFrom\r\n\t\t\r\n");
            
            #line 92 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
		Include("Clone", it); 
            
            #line default
            #line hidden
            
            #line 93 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            
            #line 94 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.NeedOnDeserialized || it.NeedOnDeserializing) { 
            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t\t#region Serialization\r\n\r\n");
            
            #line 98 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.NeedOnDeserializing) { 
            
            #line default
            #line hidden
            this.Write("\t\t[OnDeserializing]\r\n\t\tprivate void OnDeserializing(StreamingContext context)\r\n\t\t" +
                    "{\r\n");
            
            #line 102 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
		ForEach("MutableSetFieldDefaultValue", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 105 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            
            #line 106 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.NeedOnDeserialized) { 
            
            #line default
            #line hidden
            this.Write("\t\t[OnDeserialized]\r\n\t\tprivate void OnDeserialized(StreamingContext context)\r\n\t\t{\r" +
                    "\n");
            
            #line 110 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
		ForEach("MutableOnDeserialization", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 113 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            this.Write("\t\t#endregion Serialization\r\n");
            
            #line 115 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            
            #line 116 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
		Include("Equals", it); 
            
            #line default
            #line hidden
            this.Write("\t}\r\n");
            
            #line 118 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	if (it.Package != null) { 
            
            #line default
            #line hidden
            this.Write("\r\n}\r\n");
            
            #line 121 "X:\c#\modelsharp\Core\templates\MutableClass.tt"
 	} 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "X:\c#\modelsharp\Core\templates\MutableClass.tt"

private global::org.pescuma.ModelSharp.Core.model.TypeInfo _itField;

/// <summary>
/// Access the it parameter of the template.
/// </summary>
private global::org.pescuma.ModelSharp.Core.model.TypeInfo it
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
    if ((typeof(global::org.pescuma.ModelSharp.Core.model.TypeInfo).IsAssignableFrom(this.Session["it"].GetType()) == false))
    {
        this.Error("The type \'org.pescuma.ModelSharp.Core.model.TypeInfo\' of the parameter \'it\' did n" +
                "ot match the type of the data passed to the template.");
    }
    else
    {
        this._itField = ((global::org.pescuma.ModelSharp.Core.model.TypeInfo)(this.Session["it"]));
        itValueAcquired = true;
    }
}
if ((itValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("it");
    if ((data != null))
    {
        if ((typeof(global::org.pescuma.ModelSharp.Core.model.TypeInfo).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'org.pescuma.ModelSharp.Core.model.TypeInfo\' of the parameter \'it\' did n" +
                    "ot match the type of the data passed to the template.");
        }
        else
        {
            this._itField = ((global::org.pescuma.ModelSharp.Core.model.TypeInfo)(data));
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
