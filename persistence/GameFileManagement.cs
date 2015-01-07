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
        /// <summary>
        ///     This function tests the existing thipx32.dll file for known versions
        /// </summary>
        /// <returns>an object of the Thipx32DllID enum class with the file identification</returns>

        /// <summary>
        ///     This function tests the existing thipx32.dll file for known versions
        /// </summary>
        /// <param name="dllpath">Full path and filename of the thipx32.dll to check</param>
        /// <returns>an object of the Thipx32DllID enum class with the file identification</returns>


        /// <summary>
        ///     This function tests the existing thipx32.dll file for known versions
        /// </summary>
        /// <returns>an object of the Thipx32DllID enum class with the file identification</returns>

        /// <summary>
        ///     This function tests the existing thipx32.dll file for known versions
        /// </summary>
        /// <param name="dllpath">Full path and filename of the thipx32.dll to check</param>
        /// <returns>an object of the Thipx32DllID enum class with the file identification</returns>

        /// <summary>
        ///  Replace the current language.dll with an internally stored version
        /// </summary>

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

    }
}
