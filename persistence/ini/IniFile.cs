using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace tsconfig.persistence.ini
{
    class IniFile
    {
        private String filePath;

        /// <summary>This class is written for old ini files; default encoding is DOS U.S. ASCII</summary>
        /// <returns>The default encoding (DOS U.S. ASCII-437)</returns>
        /// <remarks>Since there is no constant reference to encoding 437, this is a static function rather than a constant.</remarks>
        public static Encoding DEFAULT_ENCODING() { return Encoding.GetEncoding(437); }

        // inbuilt defaults
        public static Boolean DEFAULT_INITIALCAPS = true;
        public static BooleanMode DEFAULT_BOOLEANMODE = BooleanMode.YESNO;
        public static Boolean DEFAULT_REMOVECOMMENTS = false;

        private List<IniSection> iniSections;

        /// <summary>The text encoding set for reading the ini file (read-only).</summary>
        public Encoding textEncoding { get { return _textEncoding; } }
        private Encoding _textEncoding;

        /// <summary>When enabled, this makes sure all ini keys that get saved start with a capital letter.</summary>
        public Boolean initialCaps { get; set; }
        /// <summary>The default boolean mode</summary>
        public BooleanMode booleanModeDefault { get; set; }
        /// <summary>The default behaviour for removing vomments behind values</summary>
        public Boolean removeCommentsDefault { get; set; }


        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="initialCaps">Write back all ini keys with initial capital letter</param>
        /// <param name="booleanModeDefault">The default behaviour for writing boolean strings</param>
        /// <param name="removeCommentsDefault">The default behaviour for handling the comments behind non-string values when writing a new value</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, Boolean initialCaps, BooleanMode booleanModeDefault, Boolean removeCommentsDefault, Encoding textEncoding)
        {
            if (textEncoding == null) throw new ArgumentNullException("textEncoding");
            if (filePath == null)     throw new ArgumentNullException("filePath");
            this.initialCaps = initialCaps;
            this.removeCommentsDefault = removeCommentsDefault;
            this.booleanModeDefault = booleanModeDefault;
            readIniFile(filePath, textEncoding);
        }
        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, Encoding textEncoding) : this(filePath, DEFAULT_INITIALCAPS, DEFAULT_BOOLEANMODE, DEFAULT_REMOVECOMMENTS, textEncoding) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file,
        ///     set to write back all ini keys with initial capital letter, and
        ///     with the default DOS U.S. ASCII-437 encoding.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="initialCaps">Write back all ini keys with initial capital letter</param>
        public IniFile(String filePath) : this(filePath, DEFAULT_INITIALCAPS, DEFAULT_BOOLEANMODE, DEFAULT_REMOVECOMMENTS, DEFAULT_ENCODING()) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file
        ///     that doesn't necessarily exist yet.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="filecontents">String with the file contents in it</param>
        /// <param name="initialCaps">Write back all ini keys with initial capital letter</param>
        /// <param name="booleanModeDefault">The default behaviour for writing boolean strings</param>
        /// <param name="removeCommentsDefault">The default behaviour for handling the comments behind non-string values when writing a new value</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, String filecontents, Boolean initialCaps, BooleanMode booleanModeDefault, Boolean removeCommentsDefault, Encoding textEncoding)
        {
            this.filePath = filePath;
            this._textEncoding = textEncoding;
            byte[] byteArray = Encoding.ASCII.GetBytes(filecontents);
            MemoryStream stream = new MemoryStream(byteArray);
            StreamReader reader = new StreamReader(stream, _textEncoding, false);
            this.booleanModeDefault = booleanModeDefault;
            this.iniSections = readIniContents(reader);
        }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file
        ///     that doesn't necessarily exist yet,
        ///     set to write back all ini keys with initial capital letter, and
        ///     with the default DOS U.S. ASCII-437 encoding.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="filecontents">String with the file contents in it</param>
        public IniFile(String filePath, String filecontents) : this(filePath, filecontents, DEFAULT_INITIALCAPS, DEFAULT_BOOLEANMODE, DEFAULT_REMOVECOMMENTS, DEFAULT_ENCODING()) { }

        /// <summary>
        ///     Creates an object for reading, editing and writing an ini file
        ///     that doesn't necessarily exist yet
        ///     set to write back all ini keys with initial capital letter.
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <param name="filecontents">String with the file contents in it</param>
        /// <param name="textEncoding">Text encoding to use for reading (and writing) the file</param>
        public IniFile(String filePath, String filecontents, Encoding textEncoding) : this(filePath, filecontents, DEFAULT_INITIALCAPS, DEFAULT_BOOLEANMODE, DEFAULT_REMOVECOMMENTS, textEncoding) { }


        public void readIniFile(String iniFilePath)
        {
            readIniFile(iniFilePath, DEFAULT_ENCODING());
        }

        public void readIniFile(String iniFilePath, Encoding textEncoding)
        {
            this.filePath = iniFilePath;
            this._textEncoding = textEncoding;
            if (File.Exists(filePath))
            {
                StreamReader reader = new StreamReader(filePath, _textEncoding, false);
                this.iniSections = readIniContents(reader);
            }
            else
                this.iniSections = new List<IniSection>();
        }

        private List<IniSection> readIniContents(StreamReader reader)
        {
            List<IniSection> readIniSections = new List<IniSection>();
            try
            {
                String input = null;
                IniSection iniSection = null;
                String key;
                String value;

                while ((input = reader.ReadLine()) != null)
                {
                    if (input.StartsWith("[") && input.Contains("]"))
                    {
                        String sectionName = input.Substring(1, input.IndexOf("]")-1);
                        if (!sectionName.Contains("[")) // valid ini section
                        {
                            iniSection = readIniSections.Find(i => i.name.Equals(sectionName));
                            if (iniSection == null) // doesn't exist yet
                            {
                                iniSection = new IniSection(sectionName);
                                readIniSections.Add(iniSection);
                            }
                            else // section already exists; don't allow merging of different same-name sections. (needed for correct deleting of extra ini entries)
                                iniSection = null;
                        }
                    }
                    else if (iniSection!=null) // ini section was found (everything before first ini section is ignored)
                    {
                        value = getKeyAndValue(input, out key);
                        if (key!=null)
                            iniSection.setStringValue(key, value);
                        
                    }
                }
                reader.Close();
            }
            catch (Exception) { }
            return readIniSections;
        }

        /// <summary>
        ///     Writes the modified ini object to a file 
        /// </summary>
        public Boolean writeIni()
        {
            return writeIni(this.filePath);
        }
        
        /// <summary>
        ///     Writes the modified ini object to a file 
        /// </summary>
        /// <param name="iniFilePath">Filename to write to</param>
        public Boolean writeIni(String iniFilePath)
        {
            List<String> initext;
            try
            {
                initext = new List<String>(File.ReadAllLines(iniFilePath, _textEncoding));
            }
            catch
            {
                initext = new List<String>();
            }

            foreach (IniSection section in iniSections)
            {
                // writes keys in original case
                Dictionary<String, String> keypairs = section.getKeyValuePairs();
                foreach (KeyValuePair<String, String> iniPair in keypairs)
                {
                    String newline = iniPair.Key + "=" + iniPair.Value;
                    // C&C needs initial caps, so make sure to write all keys with initial caps
                    if (initialCaps && newline[0] > 0x60 && newline[0] < 0x7B)
                    {
                        newline = (Char)(newline[0] - 0x20) + newline.Substring(1);
                    }
                    int linenumber = findLine(initext, section.name, iniPair.Key);
                    if (linenumber >= 0)
                        initext[linenumber] = newline;
                    else
                    {
                        linenumber = findLastSectionLine(initext, section.name)+1;
                        if (linenumber > 0)
                            initext.Insert(linenumber, newline);
                        else
                        {
                            initext.Add(String.Empty);
                            initext.Add("[" + section.name + "]");
                            initext.Add(newline);

                        }
                    }
                }

                // Removes all keys that are not in the section object. Does not remove empty sections.
                // Looks up keys as case insensitive.
                Dictionary<String, String> keypairsLower = section.getKeyValuePairs(true);
                int firstLine = findLine(initext,section.name,null);
                int lastLine = findLastSectionLine(initext, section.name);
                if (firstLine >= 0 && firstLine + keypairsLower.Count < lastLine)
                {
                    String key;
                    for (int line = lastLine; line > firstLine; line--)
                    {
                        getKeyAndValue(initext[line], out key);
                        if (key != null && !keypairsLower.ContainsKey(key.ToLower()))
                        {
                            initext.RemoveAt(line);
                        }
                    }
                }
            }

            //*
            // trim all empty lines off the end of the file and add a single one
            while ((initext.Count > 0 && initext[initext.Count - 1].Equals(String.Empty)))
            {
                initext.RemoveAt(initext.Count-1);
            }
            //*/

            StreamWriter writer = null;
            Boolean returnvalue = true;
            try
            {
                writer = new StreamWriter(iniFilePath, false, _textEncoding);
                foreach (String line in initext)
                    writer.WriteLine(line);
            }
            catch
            {
                returnvalue = false;
            }
            finally
            {
                if (writer !=null)
                    writer.Close();
            }
            readIniFile(iniFilePath,_textEncoding);
            return returnvalue;
        }

        private int findLine(List<String> inifile, String inisection, String inikey)
        {
            if (inifile == null)
                throw new ArgumentNullException("inifile");
            if (inisection == null)
                throw new ArgumentNullException("inisection");
            String sectionName = null;
            Boolean sectionfound = false;
            for (int linenumber = 0; linenumber < inifile.Count; linenumber++)
            {
                String s = inifile[linenumber];
                if (s.StartsWith("[") && s.Contains("]"))
                {
                    sectionName = s.Substring(1, s.IndexOf("]") - 1);
                    sectionfound = sectionName.ToLower().Equals(inisection.ToLower());
                    if (inikey == null && sectionfound)
                        return linenumber;
                }
                else if (sectionfound) // correct ini section was found
                {
                    String key;
                    getKeyAndValue(s, out key);
                    if (key!=null && key.ToLower().Equals(inikey.ToLower()))
                        return linenumber;
                }
            }
            return -1;
        }

        private int findLastSectionLine(List<String> inifile, String inisection)
        {
            int lastLine = inifile.Count-1;
            Boolean sectionfound = false;
            Boolean sectionwasfound = false;
            for (int linenumber = 0; linenumber < inifile.Count; linenumber++)
            {
                String sectionName = null;
                String s = inifile[linenumber];
                if (s.StartsWith("[") && s.Contains("]"))
                {
                    sectionName = s.Substring(1, s.IndexOf("]") - 1);
                    sectionwasfound = sectionfound;
                    sectionfound = sectionName.ToLower().Equals(inisection.ToLower());
                    // requested section was encountered last time, and the start of the new one was found now.
                    if (sectionwasfound && !sectionfound)
                    {
                        lastLine = linenumber - 1;
                        break;
                    }
                }
            }
            if (sectionwasfound || sectionfound)
            {
                while (lastLine > 0 && !(inifile[lastLine].Contains("=") && !inifile[lastLine].StartsWith(";")))
                    lastLine--;
                return lastLine;
            }
            return -1;
        }

        /// <summary>
        ///     Returns the value of the line, and returns the key name in the out parameter
        /// </summary>
        /// <param name="input">input line of text</param>
        /// <param name="key">output parameter to return the key</param>
        /// <returns>the value of the key</returns>
        private String getKeyAndValue(String input, out String key)
        {
            key = null;
            if (input.StartsWith(";")) return null;

            int separator = input.IndexOf('=');
            if (separator >= 1)
            {
                key = input.Substring(0, separator);
                return input.Substring(separator + 1);
            }
            return null;
        }

        #region getters and setters for ini values

        public String getStringValue(String sectionName, String key, String defaultValue)
        {
            Boolean success = true;
            return getStringValue(sectionName, key, defaultValue, out success);
        }

        public String getStringValue(String sectionName, String key, String defaultValue, out Boolean success)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null)
            {
                success = false;
                return defaultValue;
            }
            return iniSection.getStringValue(key, defaultValue, out success);
        }

        public void setStringValue(String sectionName, String key, String value)
        {
            IniSection iniSection = getSection(sectionName, true);
            iniSection.setStringValue(key, value);
        }

        public int getIntValue(String sectionName, String key, int defaultValue)
        {
            Boolean success;
            return getIntValue(sectionName, key, defaultValue, out success);
        }

        public int getIntValue(String sectionName, String key, int defaultValue, out Boolean success)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null)
            {
                success = false;
                return defaultValue;
            }
            return iniSection.getIntValue(key, defaultValue, out success);
        }

        public void setIntValue(String sectionName, String key, int value)
        {
            this.setIntValue(sectionName, key, value, DEFAULT_REMOVECOMMENTS);
        }

        public void setIntValue(String sectionName, String key, int value, Boolean removeComments)
        {
            IniSection iniSection = getSection(sectionName,true);
            iniSection.setIntValue(key, value, removeComments);
        }

        public Boolean getBoolValue(String sectionName, String key, Boolean defaultValue)
        {
            Boolean success;
            return getBoolValue(sectionName, key, defaultValue, out success);
        }

        public Boolean getBoolValue(String sectionName, String key, Boolean defaultValue, out Boolean success)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null)
            {
                success = false;
                return defaultValue;
            }
            return iniSection.getBoolValue(key, defaultValue, out success);
        }

        public void setBoolValue(String sectionName, String key, Boolean value)
        {
            this.setBoolValue(sectionName, key, value, booleanModeDefault, DEFAULT_REMOVECOMMENTS);
        }

        public void setBoolValue(String sectionName, String key, Boolean value, Boolean removeComments)
        {
            this.setBoolValue(sectionName, key, value, DEFAULT_BOOLEANMODE, removeComments);
        }

        public void setBoolValue(String sectionName, String key, Boolean value, BooleanMode booleanmode, Boolean removeComments)
        {
            IniSection iniSection = getSection(sectionName,true);
            iniSection.setBoolValue(key, value, booleanmode, removeComments);
        }


        public double getFloatValue(String sectionName, String key, double defaultValue)
        {
            Boolean success;
            return getFloatValue(sectionName, key, defaultValue, out success);
        }

        public double getFloatValue(String sectionName, String key, double defaultValue, out Boolean success)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null)
            {
                success = false;
                return defaultValue;
            }
            return iniSection.getFloatValue(key, defaultValue, out success);
        }

        public void setFloatValue(String sectionName, String key, double value, int precision)
        {
            this.setFloatValue(sectionName, key, value, precision, DEFAULT_REMOVECOMMENTS);
        }

        public void setFloatValue(String sectionName, String key, double value, int precision, Boolean removeComments)
        {
            IniSection iniSection = getSection(sectionName, true);
            iniSection.setFloatValue(key, value, precision, removeComments);
        }


        public void removeKey(String sectionName, String key)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null) return;
            iniSection.removeKey(key);
        }
        
        public void clearSection(String sectionName)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null) return;
            iniSection.clear();
        }

        public List<String> getSectionKeys(String sectionName)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null) return null;
            return iniSection.getKeys();
        }

        public Dictionary<String, String> getSectionContent(String sectionName)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null) return null;
            return iniSection.getKeyValuePairs();
        }

        public Dictionary<String, String> getSectionContent(String sectionName, Boolean lowercasekeys)
        {
            IniSection iniSection = getSection(sectionName);
            if (iniSection == null) return null;
            return iniSection.getKeyValuePairs(lowercasekeys);
        }


        #endregion

        private IniSection getSection(String sectionName)
        {
            return getSection(sectionName, false);
        }

        private IniSection getSection(String sectionName, Boolean createWhenNotFound)
        {
            IniSection iniSection = iniSections.Find(i => i.name.ToLower().Equals(sectionName.ToLower()));
            if (iniSection == null && createWhenNotFound) // doesn't exist yet
            {
                iniSection = new IniSection(sectionName);
                iniSections.Add(iniSection);
            }
            return iniSection;
        }

    }
}
