using System;
using System.Collections.Generic;
using System.Text;
using tsconfig.persistence.ini;
using tsconfig.domain.constants;
using System.IO;
using tsconfig.persistence;
using System.Security.Principal;
using System.Windows.Forms;

namespace tsconfig.domain
{
    class DomainController
    {
        private static DomainController _instance;
        private IniFile SUN_ini;

        /// <summary>
        ///     Default constructor.
        ///     Loads the settings and the language.
        /// </summary>
        protected DomainController()
        {
            // WARNING! This method can NOT contain any methods that use the Singleton pattern
            // to call Domaincontroller methods! If it does call methods that use it, make sure
            // such calls are ignored by checking with the hasInstance() method.
            SUN_ini = null; 

            String settingsPath = ProgramConstants.gamepath + ProgramConstants.GAME_SETTINGS;

            if (!File.Exists(settingsPath))
                SUN_ini = new IniFile(settingsPath, tsconfig.Properties.Resources.SUN_ini, Encoding.GetEncoding("windows-1252"));
            else
                SUN_ini = new IniFile(settingsPath, Encoding.GetEncoding("windows-1252"));
        }

        /// <summary>
        ///     Singleton Pattern. Returns the object of this class.
        /// </summary>
        /// <returns>The object of the DomainController class.</returns>
        public static DomainController Instance()
        {
            if (_instance == null)
            {
                _instance = new DomainController();
            }
            return _instance;
        }

        public Boolean getUnitActionLines()
        {
            return SUN_ini.getBoolValue("Options", "UnitActionLines", true);
        }

        public Boolean getWindowed()
        {
            return SUN_ini.getBoolValue("Video", "Video.Windowed", false);
        }

        public Boolean getTooltips()
        {
            return SUN_ini.getBoolValue("Options", "ToolTips", true);
        }

        public Boolean getBackbuffer()
        {
            return SUN_ini.getBoolValue("Video", "UseGraphicsPatch", true);
        }

        public Boolean getCD()
        {
            return SUN_ini.getBoolValue("Options", "NoCD", true);
        }

        public Boolean getProcAffinity()
        {
            return SUN_ini.getBoolValue("Options", "SingleProcAffinity", true);
        }

        public Boolean getMusicRepeat()
        {
            return SUN_ini.getBoolValue("Audio", "IsScoreRepeat", false);
        }

        public Boolean getMusicShuffle()
        {
            return SUN_ini.getBoolValue("Audio", "IsScoreShuffle", true);
        }

        public Boolean getIntro()
        {
            return SUN_ini.getBoolValue("Intro", "PlaySide00", true);
        }

        public double getScoreVolume()
        {
            return SUN_ini.getFloatValue("Audio", "ScoreVolume", 0.3);
        }

        public int getDragDistance()
        {
            return SUN_ini.getIntValue("Options", "DragDistance", 4);
        }

        public double getVoiceVolume()
        {
            return SUN_ini.getFloatValue("Audio", "VoiceVolume", 0.3);
        }

        public double getSoundVolume()
        {
            return SUN_ini.getFloatValue("Audio", "SoundVolume", 0.3);
        }

        public String getMpHandle()
        {
            String name = SUN_ini.getStringValue("MultiPlayer", "Handle", String.Empty);
            name = setDefaultName(name.Trim());
            return name;
        }

        public Boolean getOverrideColors()
        {
            return SUN_ini.getBoolValue("Options", "OverrideColors", false);
        }

        public Boolean getOnlyRightClickDeselect()
        {
            return SUN_ini.getBoolValue("Options", "OnlyRightClickDeselect", false);
        }

        public Boolean getDisableAltTab()
        {
            return SUN_ini.getBoolValue("Options", "DisableAltTab", false);
        }

        public Boolean getDisableEdgeScrolling()
        {
            return SUN_ini.getBoolValue("Options", "DisableEdgeScrolling", false);
        }

        public Boolean getIntegrateMumble()
        {
            return SUN_ini.getBoolValue("Options", "IntegrateMumble", false);
        }

        public int getTextBackgroundColor()
        {
            return SUN_ini.getIntValue("Options", "TextBackgroundColor", 0);
        }

        public WWColor[] getColorOverrides()
        {
            WWColor[] c = new WWColor[8];
            for (int i = 0; i < 8; i++)
            {
                int t = SUN_ini.getIntValue("ColorOverrides",string.Format("Color{0}",i),-1);
                if (t > 0)
                    c[i] = WWColor.ByIndex(t);
            }
            return c;
        }

        private string setDefaultName(String name)
        {
            if (name.Equals(String.Empty))
            {
                name = WindowsIdentity.GetCurrent().Name.ToString();
                if (name.Contains("\\"))
                    name = name.Substring(name.LastIndexOf("\\") + 1);
            }
            if (name.Length > 14) 
                name = name.Substring(0, 14);
            return name;
        }

        public Boolean saveSettings(
            Boolean unitActionLines, 
            Boolean tooltips, 
            bool Backbuffer, 
            Boolean Intro, 
            bool CD, 
            Boolean musicRepeat, 
            Boolean musicShuffle, 
            Double musicVolume, 
            Double voiceVolume,
            Double soundVolume, 
            int DragDistance,
            bool procAffinity, 
            WWColor[] ColorOverrides, 
            Boolean OverrideColors,
            Boolean OnlyRightClickDeselect,
            Boolean DisableAltTab,
            Boolean DisableEdgeScrolling,
            int TextBackgroundColor
            )
        {
            Boolean allOk = true;
            // INI SETTINGS
            SUN_ini.setBoolValue("Options", "UnitActionLines", unitActionLines);
            SUN_ini.setBoolValue("Intro", "PlaySide00", Intro);
            SUN_ini.setBoolValue("Video", "UseGraphicsPatch", Backbuffer);
            SUN_ini.setBoolValue("Options", "NoCD", CD);
            SUN_ini.setBoolValue("Options", "SingleProcAffinity", procAffinity);

            SUN_ini.setBoolValue("Options", "ToolTips", tooltips);
            SUN_ini.setBoolValue("Audio", "IsScoreRepeat", musicRepeat);
            SUN_ini.setBoolValue("Audio", "IsScoreShuffle", musicShuffle);
            SUN_ini.setFloatValue("Audio", "ScoreVolume", musicVolume, 6);
            SUN_ini.setFloatValue("Audio", "VoiceVolume", voiceVolume, 6);
            SUN_ini.setFloatValue("Audio", "SoundVolume", soundVolume, 6);
            SUN_ini.setIntValue("Options", "DragDistance", DragDistance, false);
            /* mpHandle = setDefaultName(mpHandle);
            SUN_ini.setStringValue("MultiPlayer","Handle", mpHandle); */

            for (int i = 0; i < ColorOverrides.Length; i++)
            {
                if (ColorOverrides[i] != null)
                    SUN_ini.setIntValue("ColorOverrides",string.Format("Color{0}",i),ColorOverrides[i].Index);
            }

            SUN_ini.setIntValue("Options","TextBackgroundColor", TextBackgroundColor);
            SUN_ini.setBoolValue("Options","OverrideColors", OverrideColors);
            SUN_ini.setBoolValue("Options", "OnlyRightClickDeselect", OnlyRightClickDeselect);
            SUN_ini.setBoolValue("Options", "DisableAltTab", DisableAltTab);
            SUN_ini.setBoolValue("Options", "DisableEdgeScrolling", DisableEdgeScrolling);

            if (!File.Exists(ProgramConstants.gamepath + ProgramConstants.GAME_SETTINGS))
                GameFileManagement.WriteSunIni();

            allOk &= SUN_ini.writeIni();

            return allOk;
        }
    }
}
