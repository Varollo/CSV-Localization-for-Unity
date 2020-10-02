using UnityEngine;
using UnityEngine.UI;


namespace Varollo.Localization
{
    [RequireComponent(typeof(Text))]
    public class LanguageDependentText : MonoBehaviour
    {
        private Text _text;

        private void Start()
        {
            _text = GetComponent<Text>();

            _text.text = LanguageLocalizer.GetTranslation(_text.text);
        }
    }
}
