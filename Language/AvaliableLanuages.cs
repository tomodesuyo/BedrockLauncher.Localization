using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockLauncher.Localization.Language
{
    public static class AvaliableLanuages
    {
        public static List<string> GetAll()
        {
            return new List<string>()
            {
                "en-US",
                "fr-FR",
                "fi-FI",
                "ru-RU",
                "pt-BR",
                "es-ES",
                "uk-UA",
                "zh-TW"
            };
        }
    }
}