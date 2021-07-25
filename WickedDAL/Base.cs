//////////////////////////////////////////////////////
// Base.cs
// Author: Jeff Simmons, jeff@wickedevents.co.uk, 2021
//////////////////////////////////////////////////////
#region using
using System;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace WickedDAL
{
	#region ISqlWrapperBase

	/// <summary>
	/// Interface that every wrapped class must inherit. When SqlWrapper creates 
	/// a wrapped class it uses <see cref="SqlWrapperBase">SqlWrappedBase</see> class as its base class
	/// </summary>
	public interface ISqlWrapperBase
	{
		/// <summary>
		/// Connection property
		/// </summary>
		SqlConnection Connection { get; set; }

		/// <summary>
		/// Transaction property
		/// </summary>
		SqlTransaction Transaction { get; set; }

		/// <summary>
		/// AutoCloseConnection property
		/// </summary>
		bool AutoCloseConnection { get; set; }
	}
	#endregion

	#region SqlWrapperBase

	/// <summary>
	/// Base class for every wrapped class. You can inherint your classes from 
	/// this base class or <see cref="ISqlWrapperBase">ISqlWrapperBase</see> interface
	/// </summary>
	public class SqlWrapperBase : ISqlWrapperBase
	{
		/// <summary>
		/// Inner class member representing SqlConnection object
		/// </summary>
		protected SqlConnection m_connection = null;

		/// <summary>
		/// Inner class member representing SqlTransaction object
		/// </summary>
		protected SqlTransaction m_transaction = null;

		/// <summary>
		/// Inner class member representing SqlTransaction object
		/// </summary>
		protected bool m_autoCloseConnection = false;

		/// <summary>
		/// Connection property
		/// </summary>
		public SqlConnection Connection
		{
			get
			{
				return m_connection;
			}
			set
			{
				m_connection = value;
			}
		}

		/// <summary>
		/// Transaction property
		/// </summary>
		public SqlTransaction Transaction
		{
			get
			{
				return m_transaction;
			}
			set
			{
				m_transaction = value;
			}
		}

		/// <summary>
		/// Transaction property
		/// </summary>
		public bool AutoCloseConnection
		{
			get
			{
				return m_autoCloseConnection;
			}
			set
			{
				m_autoCloseConnection = value;
			}
		}
	}
	#endregion
}
