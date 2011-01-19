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
    
    
    #line 1 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class ImmutableClass : TemplateUtils
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
            this.Write("// Automatically generated by Model#\r\n// DO NOT EDIT THIS FILE\r\n\r\n");
            
            #line 8 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("CreateUsing", it.Using); 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 10 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 if (it.Package != null) { 
            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 11 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Package));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\r\n");
            
            #line 14 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 } 
            
            #line default
            #line hidden
            
            #line 15 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("Annotation", it.Annotations); 
            
            #line default
            #line hidden
            
            #line 16 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("Annotation", it.BaseOnlyAnnotations); 
            
            #line default
            #line hidden
            this.Write("\tpublic class ");
            
            #line 17 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            
            #line 17 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 if(it.Implements != null) { 
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 17 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach(it.Implements, separator:", "); 
            
            #line default
            #line hidden
            
            #line 17 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n\t{\r\n");
            
            #line 19 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("ImmutableField", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 21 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 21 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("Param", it.Properties, separator: ", "); 
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n");
            
            #line 23 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("ImmutableParamToField", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t\tpublic ");
            
            #line 26 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 26 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.ImplementationName));
            
            #line default
            #line hidden
            this.Write(" other)\r\n\t\t{\r\n");
            
            #line 28 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("ImmutableOtherToField", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 31 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 ForEach("ImmutableProperty", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t\r\n\t\tpublic ");
            
            #line 33 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(" Clone()\r\n\t\t{\r\n\t\t\treturn (");
            
            #line 35 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(") ((ICloneable) this).Clone();\r\n\t\t}\r\n\r\n\t\tobject ICloneable.Clone()\r\n\t\t{\r\n\t\t\tretur" +
                    "n new ");
            
            #line 40 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("((");
            
            #line 40 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(") this);\r\n\t\t}\r\n\t}\r\n");
            
            #line 43 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 if (it.Package != null) { 
            
            #line default
            #line hidden
            this.Write("\r\n}\r\n");
            
            #line 46 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "X:\c#\modelsharp\Core\templates\ImmutableClass.tt"

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

private string _classField;

/// <summary>
/// Access the class parameter of the template.
/// </summary>
private string @class
{
    get
    {
        return this._classField;
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
bool classValueAcquired = false;
if (this.Session.ContainsKey("class"))
{
    if ((typeof(string).IsAssignableFrom(this.Session["class"].GetType()) == false))
    {
        this.Error("The type \'System.String\' of the parameter \'class\' did not match the type of the d" +
                "ata passed to the template.");
    }
    else
    {
        this._classField = ((string)(this.Session["class"]));
        classValueAcquired = true;
    }
}
if ((classValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("class");
    if ((data != null))
    {
        if ((typeof(string).IsAssignableFrom(data.GetType()) == false))
        {
            this.Error("The type \'System.String\' of the parameter \'class\' did not match the type of the d" +
                    "ata passed to the template.");
        }
        else
        {
            this._classField = ((string)(data));
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