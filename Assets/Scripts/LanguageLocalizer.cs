using System.Collections.Generic;
using UnityEngine;

public static class LanguageLocalizer
{
    public static int languageId { get; private set; }
    public static void SetLanguageId(int lang) => languageId = lang;
    
    private static Dictionary<string, string[]> loadedLocalizationFile = new Dictionary<string, string[]>();

    // Loads a .csv file from "/Assets/Resources" and separetes it by each row.
    // The row contains the translation to all languages supported.
    public static void LoadLocalizationFile(string resourcesPath)
    {
        TextAsset file = Resources.Load(resourcesPath) as TextAsset;

        string[] rows = file.text.Split('\n');        

        foreach(string row in rows)
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
