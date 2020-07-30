using System;
using System.IO;

namespace WebAPIAutomation.Helpers
{
    /// <summary>
    /// Log file methods.
    /// </summary>
    public static class LogHelper
    {
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;
        /// <summary>
        /// Create Log file with test case name.
        /// </summary>
        public static void CreateLogFile(string testName)
        {
            string dir = TestSettings.LogPath;
            Directory.CreateDirectory(dir);
            _streamw = File.AppendText(dir +testName+"_"+_logFileName + ".log");
        }
        /// <summary>
        /// Write message to Log file.
        /// </summary>
        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("    {0}", logMessage);
            _streamw.Flush();
        }
        /// <summary>
        /// Close Log file.
        /// </summary>
        public static void CloseLogfile()
        {
            _streamw.Close();
        }

    }
}
