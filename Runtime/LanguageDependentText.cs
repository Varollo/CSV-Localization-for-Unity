using UnityEngine;
using UnityEngine.UI;

namespace Varollo.Localization
{
    [RequireComponent(typeof(Text))]
    public class LanguageDependentText : MonoBehaviour, ILanguageDependent<string>
    {
        public string OriginalText { get; private set; }

        private Text _text;
            
        private void Start()
        {
            _text = GetComponent<Text>();
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
