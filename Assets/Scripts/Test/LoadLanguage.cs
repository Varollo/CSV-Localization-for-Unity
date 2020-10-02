using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Languages
{ 
    English,
    Portuguese,
    Chinese,
    Spanish
}

public class LoadLanguage : MonoBehaviour
{
    [SerializeField] private Languages language;
    [SerializeField] private string localizationFilePath;

    void Awake()
    {
        LanguageLocalizer.LoadLocalizationFile(localizationFilePath);
        LanguageLocalizer.SetLanguageId((int)language);
    }
}
