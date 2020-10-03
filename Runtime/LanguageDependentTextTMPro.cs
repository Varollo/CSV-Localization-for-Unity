using UnityEngine;
using TMPro;

namespace Varollo.Localization
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class LanguageDependentTextTMPro : MonoBehaviour, ILanguageDependent<string>
    {
        private TextMeshProUGUI _text;

        private void Start()
        {
            _text = GetComponent<TextMeshProUGUI>();

            _text.text = Translate(_text.text);
        }

        public string Translate(string original)
        {
            return LanguageLocalizer.GetTranslation(original);
        }
    }
}
