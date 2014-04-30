#region

using System;

#endregion

namespace AntiBrouillard
{
    public class LogLevel
    {
        //--------------------
        // CONSTANTS
        //--------------------
        public static readonly LogLevel Verbose = new LogLevel(0, "V");
        public static readonly LogLevel Debug = new LogLevel(1, "D");
        public static readonly LogLevel Info = new LogLevel(2, "I");
        public static readonly LogLevel Warning = new LogLevel(3, "W");
        public static readonly LogLevel Error = new LogLevel(4, "E");

        //--------------------
        // ATTRIBUTES
        //--------------------
        private readonly int _logLevel;
        private readonly string _logValue;

        //--------------------
        // CONSTRUCTORS
        //--------------------
        private LogLevel()
        {
            throw new NotSupportedException();
        }

        private LogLevel(int logLevel, string logValue)
        {
            _logLevel = logLevel;
            _logValue = logValue;
        }

        //--------------------
        // OVERRIDES OPERATOR
        //--------------------
        public static Boolean operator >(LogLevel l1, LogLevel l2)
        {
            if (l1 == null || l2 == null)
                return false;

            return l1._logLevel > l2._logLevel;
        }

        public static Boolean operator <(LogLevel l1, LogLevel l2)
        {
            if (l1 == null || l2 == null)
                return false;

            return l1._logLevel < l2._logLevel;
        }

        public static Boolean operator >=(LogLevel l1, LogLevel l2)
        {
            if (l1 == null && l2 == null)
                return true;

            if (l1 == null || l2 == null)
                return false;

            return l1._logLevel >= l2._logLevel;
        }

        public static Boolean operator <=(LogLevel l1, LogLevel l2)
        {
            if (l1 == null && l2 == null)
                return true;

            if (l1 == null || l2 == null)
                return false;

            return l1._logLevel <= l2._logLevel;
        }

        public override string ToString()
        {
            return _logValue;
        }
    }
}