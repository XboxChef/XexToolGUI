using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace XexToolGUI
{
    /// <summary>
    /// Log level for filtering and display.
    /// </summary>
    public enum LogLevel
    {
        Debug = 0,
        Info = 1,
        Warning = 2,
        Error = 3
    }

    /// <summary>
    /// Centralized logger with levels, timestamps, and file output support.
    /// </summary>
    public static class Logger
    {
        private static readonly object _lock = new object();
        private static LogLevel _minLevel = LogLevel.Debug;
        private static string _logFilePath;
        private static bool _logToFile;
        private static readonly List<string> _logBuffer = new List<string>();

        /// <summary>
        /// Minimum log level to display (messages below this are filtered).
        /// </summary>
        public static LogLevel MinLevel
        {
            get => _minLevel;
            set => _minLevel = value;
        }

        /// <summary>
        /// Enable or disable logging to file.
        /// </summary>
        public static bool LogToFile
        {
            get => _logToFile;
            set => _logToFile = value;
        }

        /// <summary>
        /// Path for log file output.
        /// </summary>
        public static string LogFilePath
        {
            get => _logFilePath;
            set => _logFilePath = value;
        }

        /// <summary>
        /// Event raised when a new log message is written (for UI binding).
        /// </summary>
        public static event Action<string, LogLevel> MessageLogged;

        /// <summary>
        /// Format a log message with timestamp and level prefix.
        /// </summary>
        public static string FormatMessage(string message, LogLevel level)
        {
            string levelStr = level switch
            {
                LogLevel.Debug => "DBG",
                LogLevel.Info => "INF",
                LogLevel.Warning => "WRN",
                LogLevel.Error => "ERR",
                _ => "???"
            };
            return $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{levelStr}] {message}";
        }

        private static void Write(string message, LogLevel level)
        {
            if (level < _minLevel) return;

            string formatted = FormatMessage(message, level);

            lock (_lock)
            {
                _logBuffer.Add(formatted);

                if (_logToFile && !string.IsNullOrEmpty(_logFilePath))
                {
                    try
                    {
                        File.AppendAllText(_logFilePath, formatted + Environment.NewLine, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Logger file write failed: {ex.Message}");
                    }
                }
            }

            MessageLogged?.Invoke(formatted, level);
        }

        public static void Debug(string message) => Write(message, LogLevel.Debug);
        public static void Info(string message) => Write(message, LogLevel.Info);
        public static void Warning(string message) => Write(message, LogLevel.Warning);
        public static void Error(string message) => Write(message, LogLevel.Error);

        /// <summary>
        /// Log with optional exception details.
        /// </summary>
        public static void Error(string message, Exception ex)
        {
            Write($"{message}: {ex?.Message}", LogLevel.Error);
            if (ex != null)
                Debug($"Stack: {ex.StackTrace}");
        }

        /// <summary>
        /// Get all buffered log entries.
        /// </summary>
        public static IReadOnlyList<string> GetLogBuffer()
        {
            lock (_lock)
            {
                return _logBuffer.ToArray();
            }
        }

        /// <summary>
        /// Clear the log buffer.
        /// </summary>
        public static void ClearBuffer()
        {
            lock (_lock)
            {
                _logBuffer.Clear();
            }
        }

        /// <summary>
        /// Save current log buffer to a file.
        /// </summary>
        public static bool SaveToFile(string filePath)
        {
            try
            {
                var lines = GetLogBuffer();
                File.WriteAllLines(filePath, lines, Encoding.UTF8);
                return true;
            }
            catch (Exception ex)
            {
                Error($"Failed to save log: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Start logging to file (appends to existing or creates new).
        /// </summary>
        public static void StartFileLogging(string filePath)
        {
            _logFilePath = filePath;
            _logToFile = true;
            Info($"Logging to file: {filePath}");
        }

        /// <summary>
        /// Stop logging to file.
        /// </summary>
        public static void StopFileLogging()
        {
            _logToFile = false;
            _logFilePath = null;
        }
    }
}
