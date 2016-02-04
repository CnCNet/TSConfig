using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using tsconfig.domain;
using tsconfig.domain.constants;
using System.IO;

namespace tsconfig.persistence
{
    /// <summary>
    ///     Manages the files in the game folder
    /// </summary>
    static class GameFileManagement
    {

        public static Boolean Istsconfig()
        {
            return File.Exists(ProgramConstants.gamepath + ProgramConstants.GAME_SETTINGS);
        }

        /// <summary>
        ///  Writes the default Settings.ini file to the game folder.
        /// </summary>
        public static void WriteSunIni()
        {
            File.WriteAllText(ProgramConstants.gamepath + ProgramConstants.GAME_SETTINGS, tsconfig.Properties.Resources.SUN_ini);
        }

        public static void WriteddwrapperCfg()
        {
            File.WriteAllText(ProgramConstants.gamepath + ProgramConstants.DDWRAPPER_SETTINGS, tsconfig.Properties.Resources.aqrit);
        }

        public static void Writedxwnd_ini()
        {
            File.WriteAllText(ProgramConstants.gamepath + ProgramConstants.DXWND_SETTINGS, tsconfig.Properties.Resources.dxwnd_ini);
        }

    }
}
