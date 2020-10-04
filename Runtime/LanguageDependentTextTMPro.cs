using UnityEngine;
using TMPro;

namespace Varollo.Localization
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class LanguageDependentTextTMPro : MonoBehaviour, ILanguageDependent<string>
    {
        public string OriginalText { get; private set; }

        private TextMeshProUGUI _text;

        private void Start()
        {
            _text = GetComponent<TextMeshProUGUI>();
            OriginalText = _text.text;

            UpdateTranslation();

            LanguageLocalizer.OnLanguageChanged += UpdateTranslation;
        }

        public void UpdateTranslation()
        {
            _text.text = Translate(OriginalText);
        }

        public string Translate(string original)
        {
            return LanguageLocalizer.GetTranslation(original);
        }

        private void OnDestroy()
        {
            LanguageLocalizer.OnLanguageChanged -= UpdateTranslation;
        }
    }
}
