using System;
using System.Collections.Generic;
using System.Text;

namespace Jeff.Jones.JLogger6
{
	/// <summary>
	/// This class represents a single debug log entry.  These are used
	/// as values in the debug log queue (m_dctLogQueue)
	/// </summary>
	internal class DebugLogItem
	{
		private LOG_TYPE m_lngType;
		private DateTime m_dtmLogDateTime;
		private String m_strType;
		private String m_strLogMessage;
		private String m_DetailMessage;
		private String m_ModuleName;
		private String m_MethodName;
		private Int32 m_LineNumber;
		private Int32 m_ThreadID;
		private String m_ExceptionData;
		private String m_StackData;

		/// <summary>
		/// Constructor to populate the item
		/// </summary>
		/// <param name="lngType">Type of log entry</param>
		/// <param name="dtmLogDateTime">Date-Time of the log entry</param>
		/// <param name="strLogMessage">Main message</param>
		/// <param name="pDetailMessage">Secondary or detail message</param>
		/// <param name="pExceptionData">Exception.Data information as a single string</param>
		/// <param name="pStackData">Data pulled from the stack trace.</param>
		/// <param name="moduleName">Module name where the log call was made.</param>
		/// <param name="methodName">Method name where the log call was made.</param>
		/// <param name="lineNumber">Line number of the exception or where the call was made.</param>
		/// <param name="threadID">The .NET thread ID where the log call was made.</param>
		public DebugLogItem(LOG_TYPE lngType,
							DateTime dtmLogDateTime,
							String strLogMessage,
							String pDetailMessage,
							String pExceptionData,
							String pStackData,
							String moduleName,
							String methodName,
							Int32 lineNumber,
							Int32 threadID)
		{

			m_dtmLogDateTime = dtmLogDateTime;

			m_lngType = lngType;

			m_strType = lngType.ToString();

			m_DetailMessage = pDetailMessage;

			m_strLogMessage = strLogMessage;

			m_ModuleName = moduleName;

			m_MethodName = methodName;

			m_LineNumber = lineNumber;

			m_ThreadID = threadID;

			m_ExceptionData = pExceptionData;

			m_StackData = pStackData;

		}  // END public DebugLogItem(...)

		/// <summary>
		/// Date-Time of the log entry
		/// </summary>
		public DateTime LogDateTime
		{
			get
			{
				return m_dtmLogDateTime;
			}
		}

		/// <summary>
		/// Type of log entry
		/// </summary>
		public LOG_TYPE Type
		{
			get
			{
				return m_lngType;
			}
		}

		/// <summary>
		/// String name of the log type (Type).
		/// </summary>
		public String TypeDescription
		{
			get
			{
				return m_strType;
			}
		}

		/// <summary>
		/// Main message
		/// </summary>
		public String Message
		{
			get
			{
				return m_strLogMessage;
			}
		}

		/// <summary>
		/// Secondary or detail message
		/// </summary>
		public String DetailMessage
		{
			get
			{
				return m_DetailMessage;
			}
		}

		/// <summary>
		/// Module name where the log call was made.
		/// </summary>
		public String ModuleName
		{
			get
			{
				return m_ModuleName;
			}
		}

		/// <summary>
		/// Method name where the log call was made.
		/// </summary>
		public String MethodName
		{
			get
			{
				return m_MethodName;
			}
		}

		/// <summary>
		/// Line number of the exception or where the call was made.
		/// </summary>
		public Int32 LineNumber
		{
			get
			{
				return m_LineNumber;
			}
		}

		/// <summary>
		/// The .NET thread ID where the log call was made.
		/// </summary>
		public Int32 ThreadID
		{
			get
			{
				return m_ThreadID;
			}
		}

		/// <summary>
		/// Exception.Data information as a single string
		/// </summary>
		public String ExceptionData
		{
			get
			{
				return m_ExceptionData;
			}
		}

		/// <summary>
		/// Data pulled from the stack trace.
		/// </summary>
		public String StackData
		{
			get
			{
				return m_StackData;
			}
		}

	}  // END public class DebugLogItem
}
