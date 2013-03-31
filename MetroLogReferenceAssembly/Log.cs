﻿using System;
using JetBrains.Annotations;

namespace Anotar.MetroLog
{
	/// <summary>
	/// Provides logging functions.
	/// </summary>
    public static class Log
    {

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary>
        public static void Trace()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary>
        /// <param name="format">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        public static void Trace(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Trace</c> level.
        /// </summary>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="exception">An exception to be logged.</param>
        public static void TraceException(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

		/// <summary>
		/// Writes the diagnostic message at the <c>Debug</c> level.
		/// </summary>
        public static void Debug()
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message at the <c>Debug</c> level.
		/// </summary>
		/// <param name="format">A <see langword="string" /> containing format items.</param>
		/// <param name="args">Arguments to format.</param>
        public static void Debug(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message and exception at the <c>Debug</c> level.
		/// </summary>
		/// <param name="message">A <see langword="string" /> containing format items.</param>
		/// <param name="exception">An exception to be logged.</param>
        public static void DebugException(string message, Exception exception)
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message at the <c>Info</c> level.
		/// </summary>
        public static void Info()
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message at the <c>Info</c> level.
		/// </summary>
		/// <param name="format">A <see langword="string" /> containing format items.</param>
		/// <param name="args">Arguments to format.</param>
        [StringFormatMethod("format")]
        public static void Info(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message and exception at the <c>Info</c> level.
		/// </summary>
		/// <param name="message">A <see langword="string" /> containing format items.</param>
		/// <param name="exception">An exception to be logged.</param>
        public static void InfoException(string message, Exception exception)
        {
            throw new NotImplementedException();
        }
		/// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
		/// </summary>
        public static void Warn()
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message at the <c>Warn</c> level.
		/// </summary>
		/// <param name="format">A <see langword="string" /> containing format items.</param>
		/// <param name="args">Arguments to format.</param>
        [StringFormatMethod("format")]
        public static void Warn(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message and exception at the <c>Warn</c> level.
		/// </summary>
		/// <param name="message">A <see langword="string" /> containing format items.</param>
		/// <param name="exception">An exception to be logged.</param>
        public static void WarnException(string message, Exception exception)
        {
            throw new NotImplementedException();
        }
		/// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
		/// </summary>
        public static void Error()
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message at the <c>Error</c> level.
		/// </summary>
		/// <param name="format">A <see langword="string" /> containing format items.</param>
		/// <param name="args">Arguments to format.</param>
        [StringFormatMethod("format")]
        public static void Error(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message and exception at the <c>Error</c> level.
		/// </summary>
		/// <param name="message">A <see langword="string" /> containing format items.</param>
		/// <param name="exception">An exception to be logged.</param>
        public static void ErrorException(string message, Exception exception)
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message at the <c>Fatal</c> level.
		/// </summary>
		public static void Fatal()
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Writes the diagnostic message at the <c>Fatal</c> level.
		/// </summary>
		/// <param name="format">A <see langword="string" /> containing format items.</param>
		/// <param name="args">Arguments to format.</param>
        [StringFormatMethod("format")]
		public static void Fatal(string format, params object[] args)
        {
            throw new NotImplementedException();
        }
		/// <summary>
		/// Writes the diagnostic message and exception at the <c>Fatal</c> level.
		/// </summary>
		/// <param name="message">A <see langword="string" /> containing format items.</param>
		/// <param name="exception">An exception to be logged.</param>
		public static void FatalException(string message, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}