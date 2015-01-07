using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace tsconfig.domain
{
    public static class Utilities
    {
        /// <summary>
        ///     Calculates and returns the MD5 hash value of a file.
        /// </summary>
        /// <param name="relativeFileName">The relative path.</param>
        /// <returns>The MD5 hash.</returns>
        public static String calculateMD5ForFile(String path)
        {
            String returntext = null;
            try
            {
                FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();
                returntext = BytesToString(retVal);
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
                    returntext = "File not found";
                else if (ex is UnauthorizedAccessException || ex is System.Security.SecurityException)
                    returntext = "Cannot access file";
            }
            return returntext;
        }

        public static String calculateMD5ForBytes(Byte[] buffer)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(buffer);
            return BytesToString(retVal);
        }


        private static String BytesToString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();

        }

        public static String InitialCaps(String str)
        {
            if (str.Length <= 1)
                return str.ToUpper();

            str = str.ToLower();
            str = str[0].ToString().ToUpper() + str.Substring(1);
            return str;
        }

        /// <summary>
        ///     Opens a file or url in the default web browser.
        /// </summary>
        /// <param name="pathOrUrl">Path of the local file or url</param>
        public static void openInDefaultBrowser(String pathOrUrl)
        {
            pathOrUrl = "\"" + pathOrUrl.Trim('"') + "\"";
            RegistryKey defBrowserKey = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command");
            if (defBrowserKey != null && defBrowserKey.ValueCount > 0 && defBrowserKey.GetValue("") != null)
            {
                String defBrowser = (String)defBrowserKey.GetValue("");
                if (defBrowser.Contains("%1"))
                {
                    defBrowser = defBrowser.Replace("%1", pathOrUrl);
                }
                else
                {
                    defBrowser += " " + pathOrUrl;
                }
                String defBrowserProcess;
                String defBrowserArgs;
                if (defBrowser[0] == '"')
                {
                    defBrowserProcess = defBrowser.Substring(0, defBrowser.Substring(1).IndexOf('"') + 2).Trim();
                    defBrowserArgs = defBrowser.Substring(defBrowser.Substring(1).IndexOf('"') + 2).TrimStart();
                }
                else
                {
                    defBrowserProcess = defBrowser.Substring(0, defBrowser.IndexOf(" ")).Trim();
                    defBrowserArgs = defBrowser.Substring(defBrowser.IndexOf(" ")).Trim();
                }
                if (new FileInfo(defBrowserProcess.Trim('"')).Exists)
                    Process.Start(defBrowserProcess, defBrowserArgs);
            }
        }

        /// <summary>
        ///     Checks if a string is a correct IP in the form xx.xx.xx.xx
        /// </summary>
        /// <param name="formattedIP">String to check</param>
        /// <returns>True if the string is a correct formatted IP</returns>
        public static Boolean checkFormattedIP(string formattedIP)
        {
            if (formattedIP.Length != 11)
                return false;
            Regex r = new Regex(@"[A-F0-9]{2}\.[A-F0-9]{2}\.[A-F0-9]{2}\.[A-F0-9]{2}");
            return r.IsMatch(formattedIP);
        }
    }
}
