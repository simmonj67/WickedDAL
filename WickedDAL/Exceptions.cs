﻿//////////////////////////////////////////////////////
// Exceptions.cs
// Author: Jeff Simmons, jeff@wickedevents.co.uk, 2021
//////////////////////////////////////////////////////
#region using
using System;
#endregion

namespace WickedDAL
{
	/// <summary>
	/// Exception that SqlWrapper can raise
	/// </summary>
	public sealed class SqlWrapperException : ApplicationException
	{
		/// <summary>
		/// A constructor without parameters
		/// </summary>
		internal SqlWrapperException() { }

		/// <summary>
		/// A constructor with a message parameter
		/// </summary>
		/// <param name="msg">Message parameter</param>
		internal SqlWrapperException(string msg) : base(msg) { }

		/// <summary>
		/// A constructor with message and inner exception parameters
		/// </summary>
		/// <param name="msg">Message parameter</param>
		/// <param name="inner">Inner exception</param>
		public SqlWrapperException(string msg, Exception inner) : base(msg, inner) { }
	}
}
