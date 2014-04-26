#region

using System;
using System.IO;
using System.Runtime.CompilerServices;

#endregion

namespace AntiBrouillard
{
    public static class Log
    {
        //--------------------
        // ATTRIBUTES
        //--------------------
        private static String _filePath = "WorldEditor.log";
        private static Boolean _logToFile = true;
        private static LogLevel _minErrorLevel = LogLevel.Verbose;

        public static void SetMinimumErrorLevel(LogLevel minimumLogLevel)
        {
            _minErrorLevel = minimumLogLevel;
        }

        public static void SetLogToFile(Boolean logToFile)
        {
            _logToFile = logToFile;
        }

        public static void SetFilePath(string filePath)
        {
            _filePath = filePath;
        }

        //--------------------
        // ERROR LEVEL
        //--------------------
        public static void E(string message, Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Error, message, e, file, member, line);
        }

        public static void E(string message, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Error, message, null, file, member, line);
        }

        public static void E(Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Error, null, e, file, member, line);
        }

        //--------------------
        // WARNING LEVEL
        //--------------------
        public static void W(string message, Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Warning, message, e, file, member, line);
        }

        public static void W(string message, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Warning, message, null, file, member, line);
        }

        public static void W(Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Warning, null, e, file, member, line);
        }

        //--------------------
        // INFO LEVEL
        //--------------------
        public static void I(string message, Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Info, message, e, file, member, line);
        }

        public static void I(string message, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Info, message, null, file, member, line);
        }

        public static void I(Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Info, null, e, file, member, line);
        }

        //--------------------
        // DEBUG LEVEL
        //--------------------
        public static void D(string message, Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Debug, message, e, file, member, line);
        }

        public static void D(string message, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Debug, message, null, file, member, line);
        }

        public static void D(Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Debug, null, e, file, member, line);
        }

        //--------------------
        // VERBOSE LEVEL
        //--------------------
        public static void V(string message, Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Verbose, message, e, file, member, line);
        }

        public static void V(string message, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Verbose, message, null, file, member, line);
        }

        public static void V(Exception e, [CallerFilePath] string file = "", [CallerMemberName] string member = "", [CallerLineNumber] int line = 0)
        {
            CreateLogMessage(LogLevel.Verbose, null, e, file, member, line);
        }

        //--------------------
        // PRIVATE METHODS
        //--------------------
        private static void CreateLogMessage(LogLevel logLevel, string message, Exception ex, string file, string member, int line)
        {
            if (logLevel >= _minErrorLevel)
            {
                string finalMessage = CreateFinalMessageFromTagMessageException(message, ex);
                string log = CreateLogLineFormat(logLevel, file, member, line, finalMessage);

                Console.WriteLine(log);

                if (_logToFile)
                {
                    WriteLogLineToFile(log);
                }
            }
        }

        private static string CreateFinalMessageFromTagMessageException(string message, Exception ex)
        {
            string finalMessage = "";
            if (message != null && ex != null)
            {
                finalMessage = message + "\r\n" + ex;
            }
            else if (message != null)
            {
                finalMessage = message;
            }
            else if (ex != null)
            {
                finalMessage = ex.ToString();
            }
            return finalMessage;
        }

        private static string CreateLogLineFormat(LogLevel logLevel, string file, string member, int line, string finalMessage)
        {
            return String.Format("{0} {1} {2}:{3}({4}) : {5}", logLevel, DateTime.Now.ToString("hh:mm:ss"), Path.GetFileName(file), member, line, finalMessage);
        }

        private static Boolean CreateLogFileIfNotExist(string filePath)
        {
            if (!File.Exists(filePath))
            {
                try
                {
                    FileStream fs = File.Create(filePath);

                    fs.Close();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            return true;
        }

        private static void WriteLogLineToFile(string log)
        {
            if (CreateLogFileIfNotExist(_filePath))
            {
                try
                {
                    StreamWriter sw = File.AppendText(_filePath);
                    sw.WriteLine(log);
                    sw.Flush();
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erreur lors de l'écriture d'un log " + e.Message);
                }
            }
            else
            {
                Console.WriteLine("Problème lors de la création du fichier de log !");
            }
        }
    }
}