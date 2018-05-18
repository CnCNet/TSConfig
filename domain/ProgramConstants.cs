using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace tsconfig.domain.constants
{
    class ProgramConstants
    {

        public const String GAME_SETTINGS = "SUN.ini";
        public const String LAUNCHER_SETTINGS = "Launcher.ini";

        public static String gamepath = Path.GetDirectoryName(Application.ExecutablePath).TrimEnd('\\') + @"\";

    }
}
