﻿// 
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
namespace org.pescuma.ModelSharp.Core.model
{
	public class ComponentInfo : PropertyInfo
	{
		public ComponentInfo(NamingConventions conventions, TypeInfo owner, string name, string type,
		                     bool lazy)
			: base(conventions, owner, name, type, !lazy, lazy)
		{
			Setter = null;
			WithSetter = null;
			ReadOnly = false; // !lazy; <= Needed for serialization
			DefaultValue = "new " + type + "()";
		}

		public override void MakeImmutable()
		{
			base.MakeImmutable();

			DefaultValue = "";
		}

		public override bool DeepCopy
		{
			get { return true; }
			set { base.DeepCopy = value; }
		}

		public override bool IsNullable
		{
			get { return false; }
		}
	}
}
