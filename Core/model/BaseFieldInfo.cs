// 
//  Copyright (c) 2010 Ricardo Pescuma Domenecci
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
//  
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace org.pescuma.ModelSharp.Core.model
{
	public class BaseFieldInfo
	{
		public readonly string Name;
		public string FieldName;
		public readonly string PrivateName;
		public readonly string VarName;
		public string TypeName;
		public TypeInfo TypeInfo;
		public readonly string DefineName;
		public bool ReadOnly;
		public readonly List<string> Annotations = new List<string>();
		public string Documentation;

		private double? precision;

		public double Precision
		{
			get
			{
				if (precision == null)
				{
					if (TypeName == "double" || TypeName == "double?")
						return 0.000001;
					else if (TypeName == "float" || TypeName == "float?")
						return 0.0001;
					else
						return -1;
				}
				else
				{
					return (double) precision;
				}
			}
			set { precision = value; }
		}

		public virtual bool IsNullable
		{
			get { return !IsPrimitive || TypeName.EndsWith("?"); }
		}

		public string NonNullableTypeName
		{
			get
			{
				if (!IsNullable)
					throw new InvalidOperationException();

				return TypeName.Substring(0, TypeName.Length - 1);
			}
		}

		private string defaultValue;

		public BaseFieldInfo(NamingConventions conventions, string name, string type)
		{
			Contract.Requires(StringUtils.IsValidVariableName(name));
			Contract.Requires(StringUtils.IsValidTypeName(type));
			Contract.Ensures(StringUtils.IsValidVariableName(Name));
			Contract.Ensures(StringUtils.IsValidVariableName(PrivateName));
			Contract.Ensures(StringUtils.IsValidVariableName(VarName));
			Contract.Ensures(StringUtils.IsValidTypeName(TypeName));
			Contract.Ensures(StringUtils.IsValidVariableName(DefineName));

			Name = name;
			FieldName = PrivateName = conventions.ToFieldName(name);
			VarName = conventions.ToVarName(name);
			TypeName = type;
			DefineName = conventions.ToDefineName(name);
			ReadOnly = false;
		}

		public string DefaultValue
		{
			get
			{
				if (defaultValue == "")
					return null;

				return defaultValue;
			}
			set
			{
				defaultValue = value;

				if (TypeName == "string" && defaultValue != null
				    && (defaultValue.Length < 2 || defaultValue[0] != '"' || defaultValue[-1] != '"'))
				{
					defaultValue = defaultValue.Replace("\"", "\\\"");
					defaultValue = "\"" + defaultValue + "\"";
				}
			}
		}

		public bool IsPrimitive
		{
			get
			{
				HashSet<string> simpleTypes = new HashSet<string>();
				simpleTypes.Add("sbyte");
				simpleTypes.Add("byte");
				simpleTypes.Add("short");
				simpleTypes.Add("ushort");
				simpleTypes.Add("int");
				simpleTypes.Add("uint");
				simpleTypes.Add("long");
				simpleTypes.Add("ulong");
				simpleTypes.Add("char");
				simpleTypes.Add("float");
				simpleTypes.Add("double");
				simpleTypes.Add("bool");
				simpleTypes.Add("decimal");

				return simpleTypes.Contains(TypeName);
			}
		}

		public bool IsPrimitiveOrString
		{
			get
			{
				var stringNames = new HashSet<string>();
				stringNames.Add("string");
				stringNames.Add("String");

				return IsPrimitive || stringNames.Contains(TypeName);
			}
		}

		public virtual bool CanListenTo
		{
			get { return !IsPrimitiveOrString; }
		}

		public virtual string CreateExternalCopyMethod(string varName)
		{
			if (IsPrimitive)
				return varName;

			if (TypeName == "string" || TypeName == "string")
				return "string.Copy(" + varName + ")";

			return null;
		}

		public bool IsGenerated
		{
			get { return TypeInfo != null; }
		}

		public bool HasCopyConstructor
		{
			get { return TypeInfo != null && TypeInfo.Cloneable; }
		}
	}
}
