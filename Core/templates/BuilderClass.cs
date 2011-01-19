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
    
    
    #line 1 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class BuilderClass : TemplateUtils
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
            
            #line 8 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 ForEach("CreateUsing", it.Using); 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 10 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 if (it.Package != null) { 
            
            #line default
            #line hidden
            this.Write("namespace ");
            
            #line 11 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Package));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\r\n");
            
            #line 14 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\tpublic class ");
            
            #line 15 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(@class));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n");
            
            #line 17 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 ForEach("BuilderField", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic virtual ");
            
            #line 19 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(@class));
            
            #line default
            #line hidden
            this.Write(" Set(");
            
            #line 19 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(" other) \r\n\t\t{\r\n");
            
            #line 21 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 ForEach("BuilderSetFromOther", it.Properties); 
            
            #line default
            #line hidden
            this.Write("\t\t\treturn this;\r\n\t\t}\r\n\r\n");
            
            #line 25 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 // Setters
foreach(var prop in it.Properties) {
	if (prop.IsCollection) { 
		var col = (CollectionInfo) prop; 
            
            #line default
            #line hidden
            this.Write("\t\tpublic virtual ");
            
            #line 29 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(@class));
            
            #line default
            #line hidden
            this.Write(" Clear");
            
            #line 29 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write("() \r\n\t\t{\r\n\t\t\t");
            
            #line 31 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.PrivateName));
            
            #line default
            #line hidden
            this.Write(".Clear();\r\n\t\t\treturn this;\r\n\t\t}\r\n\t\tpublic virtual ");
            
            #line 34 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(@class));
            
            #line default
            #line hidden
            this.Write(" AddTo");
            
            #line 34 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 34 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Contents));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 34 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.VarName));
            
            #line default
            #line hidden
            this.Write(") \r\n\t\t{\r\n\t\t\t");
            
            #line 36 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.PrivateName));
            
            #line default
            #line hidden
            this.Write(".Add(");
            
            #line 36 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.VarName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\treturn this;\r\n\t\t}\r\n\t\tpublic virtual ");
            
            #line 39 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(@class));
            
            #line default
            #line hidden
            this.Write(" AddTo");
            
            #line 39 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Name));
            
            #line default
            #line hidden
            this.Write("(IEnumerable<");
            
            #line 39 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.Contents));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 39 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.VarName));
            
            #line default
            #line hidden
            this.Write(") \r\n\t\t{\r\n\t\t\t");
            
            #line 41 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.PrivateName));
            
            #line default
            #line hidden
            this.Write(".AddRange(");
            
            #line 41 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(col.VarName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\treturn this;\r\n\t\t}\r\n\r\n");
            
            #line 45 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
	} else { 
            
            #line default
            #line hidden
            this.Write("\t\tpublic virtual ");
            
            #line 46 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(@class));
            
            #line default
            #line hidden
            this.Write(" Set");
            
            #line 46 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 46 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.TypeName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 46 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.VarName));
            
            #line default
            #line hidden
            this.Write(") \r\n\t\t{\r\n\t\t\t");
            
            #line 48 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.PrivateName));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 48 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(prop.VarName));
            
            #line default
            #line hidden
            this.Write(";\r\n\t\t\treturn this;\r\n\t\t}\r\n\r\n");
            
            #line 52 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
	}
} 
            
            #line default
            #line hidden
            this.Write("\t\tpublic virtual ");
            
            #line 54 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write(" Build()\r\n\t\t{\r\n\t\t\treturn new ");
            
            #line 56 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(it.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 56 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 ForEach("PrivateName", it.Properties, separator: ", "); 
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n\t}\r\n");
            
            #line 59 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 if (it.Package != null) { 
            
            #line default
            #line hidden
            this.Write("\r\n}\r\n");
            
            #line 62 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Desenvolvimento\c#\ModelSharp\Core\templates\BuilderClass.tt"

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