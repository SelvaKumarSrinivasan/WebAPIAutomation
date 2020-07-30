using System;
using System.Configuration;
using System.IO;

namespace WebAPIAutomation
{   
    /// <summary>
    /// Values stored from App.config file.
    /// </summary>
    public static class TestSettings
    {
        public static string BrowserType = ConfigurationManager.AppSettings["BrowserType"];
        public static string TestDataSheetPath = GetRootDirectory() + "\\" + ConfigurationManager.AppSettings["TestDataSheet"];
        public static string URL = ConfigurationManager.AppSettings["URL"];
        public static string LogPath = GetRootDirectory() + "\\" + ConfigurationManager.AppSettings["LogFolder"];
        /// <summary>
        /// Method to get root directory.
        /// </summary>
        public static string GetRootDirectory()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            return currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
        }
    }
}
