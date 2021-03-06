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
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace org.pescuma.ModelSharp.Lib
{
	public static class ModelUtils
	{
		public static string NameOfParameter(Action<int> property)
		{
			return property.Method.GetParameters()[0].Name;
		}

		public static string NameOfProperty<T>(Expression<Func<T>> property)
		{
			var lambda = (LambdaExpression) property;
			var memberExpression = (MemberExpression) lambda.Body;
			return GetNames(memberExpression);
		}

		public static string NameOfProperty<TType, TProperty>(Expression<Func<TType, TProperty>> property)
		{
			var lambda = (LambdaExpression) property;
			var memberExpression = (MemberExpression) lambda.Body;
			return GetNames(memberExpression);
		}

		private static string GetNames(MemberExpression memberExpression)
		{
			var names = new StringBuilder();

			while (memberExpression != null)
			{
				if (memberExpression.Member.MemberType != MemberTypes.Property)
					break;

				if (names.Length > 0)
					names.Insert(0, ".");
				names.Insert(0, memberExpression.Member.Name);

				if (memberExpression.Expression is MethodCallExpression)
				{
					var mc = (MethodCallExpression) memberExpression.Expression;
					memberExpression = mc.Object as MemberExpression;
				}
				else
				{
					memberExpression = memberExpression.Expression as MemberExpression;
				}
			}

			return names.ToString();
		}
	}
}
