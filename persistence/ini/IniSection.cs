using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace tsconfig.persistence.ini
{
    class IniSection
    {
        private List<String> iniKeys;
        private List<String> iniKeysLower;
        private List<String> iniValues;
        public String name { get; set; }
        // not sure if I'll use this
        private Boolean isMerged { get; set; }

        public IniSection(String name)
        {
            this.name = name;
            iniKeys = new List<String>();
            iniKeysLower = new List<String>();
            iniValues = new List<String>();
        }

        public String getStringValue(String key, String defaultValue, out Boolean success)
        {
            success = false;
            int index = iniKeysLower.IndexOf(key.ToLower());
            success = index > -1;
            if (success) return iniValues[index];
            return defaultValue;
        }

        public void setStringValue(String key, String value)
        {
            int index = iniKeysLower.IndexOf(key.ToLower());
            Boolean success = index > -1;
            if (success)
                iniValues[index] = value;
            else
            {
                iniKeysLower.Add(key.ToLower());
                iniKeys.Add(key);
                iniValues.Add(value);
            }
        }

        public int getIntValue(String key, int defaultValue, out Boolean success)
        {
            String value = getStringValue(key, defaultValue.ToString(), out success);
            if (success)
            {
                try
                {
                    cutOffComment(ref value);
                    int intvalue = int.Parse(value);
                    return intvalue;
                }
                catch { }
            }
            return defaultValue;
        }

        public void setIntValue(String key, int value, Boolean removeComments)
        {
            Boolean exists;
            String strValue = getStringValue(key, String.Empty, out exists);
            if (exists)
            {
                String comment = (removeComments ? String.Empty : cutOffComment(ref strValue));
                strValue = value.ToString() + comment;
            }
            else
            {
                strValue = value.ToString();
            }
            setStringValue(key, strValue);
        }

        public Boolean getBoolValue(String key, Boolean defaultValue, out Boolean success)
        {
            String value = getStringValue(key, defaultValue.ToString(), out success);
            Boolean returnvalue = defaultValue;
            if (success && value.Length > 0)
            {
                cutOffComment(ref value);
                switch (value.ToLower()[0])
                {
                    case 'y': // yes
                    case 't': // true
                    case 'a': // aye
                    case 'e': // enabled
                        returnvalue = true; break;
                    case 'n': // no / nay
                    case 'f': // false
                    case 'd': // disabled
                        returnvalue = false; break;
                    default:
                        try
                        {
                            int intvalue = int.Parse(value);
                            if (intvalue == 0) returnvalue = false;
                            if (intvalue == 1) returnvalue = true;
                        }
                        catch{} break;
                }

            }
            return returnvalue;
        }

        public void setBoolValue(String key, Boolean value, BooleanMode booleanmode, Boolean removeComments)
        {
            Boolean exists;
            String strValue = getStringValue(key, String.Empty, out exists);
            String comment = String.Empty;
            if (exists)
            {
                comment = (removeComments ? String.Empty : cutOffComment(ref strValue));
            }
            switch (booleanmode)
            {
                case BooleanMode.ONEZERO:
                    strValue = (value ? "1" : "0"); break;
                case BooleanMode.YESNO:
                    strValue = (value ? "Yes" : "No"); break;
                case BooleanMode.ENABLEDDISABLED:
                    strValue = (value ? "Enabled" : "Disabled"); break;
                case BooleanMode.AYENAY:
                    strValue = (value ? "Aye" : "Nay"); break;
                default: // includes True/False
                    strValue = value.ToString(); break;
            }
            strValue += comment;
            setStringValue(key, strValue);
        }

        public double getFloatValue(String key, double defaultValue, out Boolean success)
        {
            String value = getStringValue(key, defaultValue.ToString(), out success);
            if (success)
            {
                try
                {
                    cutOffComment(ref value);
                    double floatvalue = Convert.ToDouble(value, CultureInfo.InvariantCulture);
                    return floatvalue;
                }
                catch { }
            }
            return defaultValue;
        }

        public void setFloatValue(String key, double value, int precision, Boolean removeComments)
        {
            Boolean exists;
            String strValue = getStringValue(key, String.Empty, out exists);
            if (exists)
            {
                String comment = (removeComments ? String.Empty : cutOffComment(ref strValue));
                strValue = Convert.ToString(value, CultureInfo.InvariantCulture);
                if (!strValue.Contains("."))
                    strValue+='.';
                if (strValue.Length-strValue.LastIndexOf(".")-1 > precision)
                    strValue=strValue.Substring(0,strValue.LastIndexOf(".")+7);
                while (strValue.Length - strValue.LastIndexOf(".") - 1 < precision)
                    strValue += '0';
            }
            else
            {
                strValue = value.ToString();
            }
            setStringValue(key, strValue);
        }


        /// <summary>
        ///     Cuts the comment off the given string value, and returns the comment that was cut off.
        /// </summary>
        /// <param name="value">Reference to the string to change</param>
        /// <returns>The comment that was cut off the value</returns>
        private String cutOffComment(ref String value)
        {
            int spaceOffset = value.IndexOf(' ');
            int semicolonOffset = value.IndexOf(';');
            int commentOffset;
            if (spaceOffset >=0 && semicolonOffset >=0)
                commentOffset = Math.Min(spaceOffset, semicolonOffset);
            else if (spaceOffset >= 0)
                commentOffset = spaceOffset;
            else
                commentOffset = semicolonOffset;
            if (commentOffset > -1)
            {
                String comment = value.Substring(commentOffset);
                value = value.Substring(0, commentOffset);
                return comment;
            }
            return String.Empty;
        }

        public void removeKey(String key)
        {
            int index = iniKeys.FindIndex(k => k.ToLower().Equals(key.ToLower()));
            Boolean success = index > -1;
            if (success)
            {
                iniKeys.RemoveAt(index);
                iniValues.RemoveAt(index);
            }
        }

        public void clear()
        {
            iniKeys.Clear();
            iniValues.Clear();
        }

        public List<String> getKeys()
        {
            return new List<String>(iniKeys);
        }
        
        public Dictionary<String, String> getKeyValuePairs()
        {
            return getKeyValuePairs(false);
        }

        public Dictionary<String, String> getKeyValuePairs(Boolean lowercasekeys)
        {
            Dictionary<String, String> dictionary = new Dictionary<String,String>();
            for(int i=0; i< iniKeys.Count;  i++)
                dictionary.Add((lowercasekeys ? iniKeysLower[i] : iniKeys[i]), iniValues[i]);
            return dictionary;
            /*
            // Requires .net 3.5 to work. Replaced because it's the only thing keeping it from running on 2.0.
            return iniKeys
                    .Select((k, i) => new { k, v = iniValues[i] })
                        .ToDictionary(x => (lowercasekeys ? x.k.ToLower() : x.k), x => x.v);
            //*/
        }

    }
}
