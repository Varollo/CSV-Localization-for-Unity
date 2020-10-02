# .csv Localization For Unity
.csv based localization system for Unity.

# How to use it
The .csv file must be organized in a specific way, with each frase separated by rows and languages by colums.

When you want to load the localization file, use LanguageLocalizer.LoadLocalizationFile("pathToTheFile").
Keep in mind your file must be inside a folder called Resources.
Also remember you must start the path after Resources/, and ommit the .csv extension.

After that, you can set the current language at any time using LanguageLocalizer.SetLanguageId(ID), where ID corresponds to the colum of your desired language.

To translate a text, use the LanguageDependentText component on a gameobject with a Text component.
Write the text in the first language you have on your .csv file and the script will translate it to the current language.

If you are using TextMeshPro, follow the same steps, but use the LanguageDependentTextTMPro component instead.
