using System.Collections.Generic;
using UnityEngine;

namespace Varollo.Localization
{
    public static class LanguageLocalizer
    {
        public static int LanguageId { get; private set; }

        public static int LoadedLanguages { get; private set; }

        private static Dictionary<string, string[]> LocalizationDictionary { get; set; }

        // Separetes the file by each row.
        // The row contains the translation to all languages supported.
        public static void LoadLocalizationFile(TextAsset localizationFile)
        {
            LocalizationDictionary = new Dictionary<string, string[]>();

            string[] rows = localizationFile.text.Split('\n');

            foreach (string row in rows)
            {
                string[] fields = row.Split(',');

                LoadedLanguages = fields.Length;

                if(!LocalizationDictionary.ContainsKey(fields[0]))
                {
                    LocalizationDictionary.Add(fields[0], fields);
                }
            }
        }

        public static void SetLanguageId(int lang)
        {
            if(lang < LoadedLanguages && lang >= 0)
            {
                LanguageId = lang;
            }
            else
            {
                Debug.LogWarning($"Language ID of {lang} is not a valid ID.");
            }
        }

        public static string GetTranslation(string original)
        {
			if(LocalizationDictionary == null)
			{
				Debug.LogWarning($"No localization file loaded. Call LoadLocalizationFile() first.");
                return original;
			}
            if(LocalizationDictionary.ContainsKey(original))
            {
                return LocalizationDictionary[original][LanguageId];
            }
            else
            {
                Debug.LogWarning($"Localization file does not contain a translation for {original}.");
                return original;
            }
        }
    }
}
