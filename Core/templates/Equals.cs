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
    
    
    #line 1 "X:\c#\modelsharp\Core\templates\Equals.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class Equals : TemplateUtils
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

            
            #line 4 "X:\c#\modelsharp\Core\templates\Equals.tt"
 	if (it.Equals) { 
            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t\t#region Equals\r\n\r\n\t\tpublic bool Equals(");
            
            #line 8 "X:\c#\modelsharp\Core\templates\Equals.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(" other)\r\n\t\t{\r\n\t\t\tif (ReferenceEquals(null, other)) return false;\r\n\t\t\tif (Referenc" +
                    "eEquals(this, other)) return true;\r\n");
            
            #line 12 "X:\c#\modelsharp\Core\templates\Equals.tt"
 		ForEach("CollectionEquals", it.CollectionProperties); 
            
            #line default
            #line hidden
            this.Write("\t\t\treturn ");
            
            #line 13 "X:\c#\modelsharp\Core\templates\Equals.tt"
 ForEach("PropertyEquals", it.SimpleOrComponentProperties, separator: " && "); 
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t}\r\n\r\n\t\tpublic override bool Equals(object obj)\r\n\t\t{\r\n\t\t\tif (ReferenceEquals(" +
                    "null, obj)) return false;\r\n\t\t\tif (ReferenceEquals(this, obj)) return true;\r\n\t\t\ti" +
                    "f (obj.GetType() != typeof (");
            
            #line 20 "X:\c#\modelsharp\Core\templates\Equals.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(")) return false;\r\n\t\t\treturn Equals((");
            
            #line 21 "X:\c#\modelsharp\Core\templates\Equals.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(") obj);\r\n\t\t}\r\n\r\n\t\tpublic override int GetHashCode()\r\n\t\t{\r\n\t\t\tunchecked\r\n\t\t\t{\r\n\t\t\t" +
                    "\tint result = 0;\r\n");
            
            #line 29 "X:\c#\modelsharp\Core\templates\Equals.tt"
 		ForEach("HashCode", it.NonComputedProperties); 
            
            #line default
            #line hidden
            this.Write("\t\t\t\treturn result;\r\n\t\t\t}\r\n\t\t}\r\n\r\n\t\tpublic static bool operator ==(");
            
            #line 34 "X:\c#\modelsharp\Core\templates\Equals.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write(" left, ");
            
            #line 34 "X:\c#\modelsharp\Core\templates\Equals.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write(" right)\r\n\t\t{\r\n\t\t\treturn Equals(left, right);\r\n\t\t}\r\n\r\n\t\tpublic static bool operato" +
                    "r !=(");
            
            #line 39 "X:\c#\modelsharp\Core\templates\Equals.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write(" left, ");
            
            #line 39 "X:\c#\modelsharp\Core\templates\Equals.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write(" right)\r\n\t\t{\r\n\t\t\treturn !Equals(left, right);\r\n\t\t}\r\n\r\n\t\t#endregion Equals\r\n");
            
            #line 45 "X:\c#\modelsharp\Core\templates\Equals.tt"
 	} 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "X:\c#\modelsharp\Core\templates\Equals.tt"

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
