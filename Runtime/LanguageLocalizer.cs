using System.Collections.Generic;
using UnityEngine;

namespace Varollo.Localization
{
    public static class LanguageLocalizer
    {
        public static int languageId { get; private set; }
        public static void SetLanguageId(int lang) => languageId = lang;

        private static Dictionary<string, string[]> loadedLocalizationFile = new Dictionary<string, string[]>();

        // Separetes the file by each row.
        // The row contains the translation to all languages supported.
        public static void LoadLocalizationFile(TextAsset localizationFile)
        {
            string[] rows = localizationFile.text.Split('\n');

            foreach (string row in rows)
            {
                string[] fields = row.Split(',');

                loadedLocalizationFile.Add(fields[0], fields);
            }
        }

        public static string GetTranslation(string englishText)
        {
            return loadedLocalizationFile[englishText][languageId];
        }
    }
}
