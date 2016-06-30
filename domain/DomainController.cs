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
        private IniFile SUN_ini, ddwrapperCfg, dxwnd_ini;

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
            ddwrapperCfg = null;
            dxwnd_ini = null;

            String settingsPath = ProgramConstants.gamepath + ProgramConstants.GAME_SETTINGS;
            String ddwrapperCfgPath = ProgramConstants.gamepath + ProgramConstants.DDWRAPPER_SETTINGS;
            String dxwndPath = ProgramConstants.gamepath + ProgramConstants.DXWND_SETTINGS;

            if (!File.Exists(settingsPath))
                SUN_ini = new IniFile(settingsPath, tsconfig.Properties.Resources.SUN_ini, Encoding.GetEncoding("windows-1252"));
            else
                SUN_ini = new IniFile(settingsPath, Encoding.GetEncoding("windows-1252"));

            if (!File.Exists(dxwndPath))
                dxwnd_ini = new IniFile(dxwndPath, tsconfig.Properties.Resources.dxwnd_ini, Encoding.Default);
            else
                dxwnd_ini = new IniFile(dxwndPath, Encoding.Default);

            if (!File.Exists(ddwrapperCfgPath))
                ddwrapperCfg = new IniFile(ddwrapperCfgPath, tsconfig.Properties.Resources.aqrit, false, BooleanMode.ONEZERO, false, Encoding.Default);
            else
                ddwrapperCfg = new IniFile(ddwrapperCfgPath, false, BooleanMode.ONEZERO, false, Encoding.Default);
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

        public String getCurrentGameRes()
        {
            bool success;
            int width = 800;
            int height = 600;
            width = SUN_ini.getIntValue("Video","ScreenWidth",800, out success);
            if (success)
                height = SUN_ini.getIntValue("Video", "ScreenHeight", 600, out success);

            return width + "x" + height;
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

        public bool getDxWndStatus()
        {
            string _DxWndDll = ProgramConstants.gamepath + "dxwnd.dll";
            string _DxWndDDrawDll = ProgramConstants.gamepath + "ddraw.dll";

            if (!File.Exists(_DxWndDll) || !File.Exists(_DxWndDDrawDll))
                return false;
            else
            {
                if ((Utilities.calculateMD5ForFile(_DxWndDll) == "3d07d55f97fd767fb6d1a6e2bfdfaab2") && (Utilities.calculateMD5ForFile(_DxWndDDrawDll) == "fbbf707204517c3acf3d165ee580593d"))
                    return true;
                else
                    return false;

            }
        }

        public bool getDDwrapperStatus()
        {
            string _DDrawDll = ProgramConstants.gamepath + "ddraw.dll";
            if (!File.Exists(_DDrawDll)) return false;
            else
            {
                if (Utilities.calculateMD5ForFile(_DDrawDll) == "a216b85632289b135487bb33721bafb7")
                    return true;
                else return false;
            }
        }

        public bool getTSDDrawStatus()
        {
            string _TSDDraw = ProgramConstants.gamepath + "ddraw.dll";
            if (!File.Exists(_TSDDraw)) return false;
            else
            {
                if (Utilities.calculateMD5ForFile(_TSDDraw) == "6e23b8994fe47ea78eb224badedbc704")
                    return true;
                else return false;
            }
        }

        public bool getIEDDrawStatus()
        {
            string _DDrawDll = ProgramConstants.gamepath + "ddraw.dll";
            string _libwineDll = ProgramConstants.gamepath + "libwine.dll";
            string _wined3dDll = ProgramConstants.gamepath + "wined3d.dll";

            if (!File.Exists(_DDrawDll) || !File.Exists(_libwineDll) || !File.Exists(_wined3dDll)) return false;
            else
            {
                if ((Utilities.calculateMD5ForFile(_DDrawDll) == "54bb31d0eed33a487de145f118a75df3") &&
                (Utilities.calculateMD5ForFile(_libwineDll) == "2b083c0af9c5ca9f7681bdeeb7eca8c4") &&
                (Utilities.calculateMD5ForFile(_wined3dDll) == "500453184e14d73f9a00ac749d5a3c94"))
                    return true;
                else return false;
            }
        }

        public bool getDxWndEnabled() 
        {
            return dxwnd_ini.getBoolValue("DxWnd", "Enabled", false);
        }

        public bool getDxWndWindow()
        {
            return dxwnd_ini.getBoolValue("DxWnd", "RunInWindow", false);
        }

        public bool getDxWndWindowFrame()
        {
            return dxwnd_ini.getBoolValue("DxWnd", "NoWindowFrame", false);
        }

        public bool getDxDirectDrawEmulation()
        {
            return dxwnd_ini.getBoolValue("DxWnd", "ForceDirectDrawEmulation", false);
        }

        public int getDxEmulationType()
        {
            return dxwnd_ini.getIntValue("DxWnd", "Emulation", 1);
        }

        public bool getNoVideoMemory()
        {
            return ddwrapperCfg.getBoolValue("ddraw", "NoVideoMemory", false);
        }

        public bool getFakeVsync()
        {
            return ddwrapperCfg.getBoolValue("ddraw", "FakeVsync", false);
        }

        public bool getDirectDrawEmulation()
        {
            return ddwrapperCfg.getBoolValue("ddraw", "ForceDirectDrawEmulation", false);
        }

        public Boolean saveSettings(
            int width, 
            int height, 
            Boolean unitActionLines, 
            Boolean tooltips, 
            Boolean videoWindowed, 
            bool Backbuffer, 
            Boolean Intro, 
            bool CD, 
            Boolean musicRepeat, 
            Boolean musicShuffle, 
            Double musicVolume, 
            Double voiceVolume,
            Double soundVolume, 
            int DragDistance,
            bool _GP_IEddraw, 
            bool _GP_ddwrapper, 
            bool _GP_NoVideoMemory, 
            bool _GP_FakeVsync,
            bool ddEmulation,
            int dxEmulationType,
            bool _GP_TSDDraw,
            bool _GP_dxwnd,
            bool _GP_DxWndEnabled,
            bool _GP_DxWndWindow,
            bool _GP_DxWndWindowFrame,
            bool dxDDEmulation,
            bool procAffinity, 
            WWColor[] ColorOverrides, 
            Boolean OverrideColors,
            Boolean OnlyRightClickDeselect,
            Boolean DisableAltTab,
            Boolean DisableEdgeScrolling,
            Boolean IntegrateMumble,
            int TextBackgroundColor
            )
        {
            Boolean allOk = true;
            // INI SETTINGS
            SUN_ini.setIntValue("Video", "ScreenWidth", width, false);
            SUN_ini.setIntValue("Video", "ScreenHeight", height, false);

            SUN_ini.setBoolValue("Options", "UnitActionLines", unitActionLines);
            SUN_ini.setBoolValue("Intro", "PlaySide00", Intro);
            SUN_ini.setBoolValue("Video", "Video.Windowed", videoWindowed);
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

            SUN_ini.setIntValue("Video", "ScreenWidth", width, false);
            SUN_ini.setIntValue("Video", "ScreenHeight", height, false);

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
            SUN_ini.setBoolValue("Options", "IntegrateMumble", IntegrateMumble);

            if (!File.Exists(ProgramConstants.gamepath + ProgramConstants.GAME_SETTINGS))
                GameFileManagement.WriteSunIni();

            ddwrapperCfg.setBoolValue("ddraw", "NoVideoMemory", _GP_NoVideoMemory);
            ddwrapperCfg.setBoolValue("ddraw", "FakeVsync", _GP_FakeVsync);
            ddwrapperCfg.setBoolValue("ddraw", "ForceDirectDrawEmulation", ddEmulation);

            if (!File.Exists(ProgramConstants.gamepath + ProgramConstants.DDWRAPPER_SETTINGS))
                GameFileManagement.WriteddwrapperCfg();

            dxwnd_ini.setBoolValue("DxWnd", "NoWindowFrame", _GP_DxWndWindowFrame);
            dxwnd_ini.setBoolValue("DxWnd", "Enabled", _GP_DxWndEnabled);
            dxwnd_ini.setBoolValue("DxWnd", "RunInWindow", _GP_DxWndWindow);
            dxwnd_ini.setBoolValue("DxWnd", "ForceDirectDrawEmulation", dxDDEmulation);
            dxwnd_ini.setIntValue("DxWnd", "Emulation", dxEmulationType);

            if (!File.Exists(ProgramConstants.gamepath + ProgramConstants.DXWND_SETTINGS))
                GameFileManagement.Writedxwnd_ini();

            allOk &= SUN_ini.writeIni() && ddwrapperCfg.writeIni() && dxwnd_ini.writeIni();

            /* DLL SETTINGS */

            string _DDrawDll = ProgramConstants.gamepath + "ddraw.dll";
            string _libwineDll = ProgramConstants.gamepath + "libwine.dll";
            string _wined3dDll = ProgramConstants.gamepath + "wined3d.dll";
            string _dxwndDll = ProgramConstants.gamepath + "dxwnd.dll";
            string _dxwnd_ddrawDll = ProgramConstants.gamepath + "ddraw.dll"; 
            
            try
            {
                if (File.Exists(_DDrawDll)) File.Delete(_DDrawDll);
                if (File.Exists(_libwineDll)) File.Delete(_libwineDll);
                if (File.Exists(_wined3dDll)) File.Delete(_wined3dDll);
                if (File.Exists(_dxwndDll)) File.Delete(_dxwndDll);
                if (File.Exists(_dxwnd_ddrawDll)) File.Delete(_dxwnd_ddrawDll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                allOk = false;
            }

            if (_GP_dxwnd) 
            {
                try
                {
                    File.WriteAllBytes(_dxwnd_ddrawDll, tsconfig.Properties.Resources.dxwnd_ddraw);
                    File.WriteAllBytes(_dxwndDll, tsconfig.Properties.Resources.dxwnd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    allOk = false;
                }
            }


            if (_GP_ddwrapper)
            {
                try
                {
                    File.WriteAllBytes(_DDrawDll, tsconfig.Properties.Resources.ddwrapper);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    allOk = false;
                }
            }


            if (_GP_TSDDraw)
            {
                try
                {
                    File.WriteAllBytes(_DDrawDll, tsconfig.Properties.Resources.tsddraw);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    allOk = false;
                }
            }

            else if (_GP_IEddraw)
            {
                try
                {
                    File.WriteAllBytes(_DDrawDll, tsconfig.Properties.Resources.ddraw);
                    File.WriteAllBytes(_libwineDll, tsconfig.Properties.Resources.libwine);
                    File.WriteAllBytes(_wined3dDll, tsconfig.Properties.Resources.wined3d);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    allOk = false;
                }
            }

            return allOk;
        }
    }
}
