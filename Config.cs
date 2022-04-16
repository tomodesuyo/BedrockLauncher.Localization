using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockLauncher.Localization
{
    public static class Config
    {
        public static bool InstallerMode { get; set; } = false;
        public static string LangFolder => InstallerMode ? "lang_installer" : "lang";
    }
}
