using UnityEngine;
using UnityEngine.UI;

namespace Varollo.Localization
{
    [RequireComponent(typeof(Text))]
    public class LanguageDependentText : MonoBehaviour, ILanguageDependent<string>
    {
        private Text _text;
            
        private void Start()
        {
            _text = GetComponent<Text>();

            _text.text = Translate(_text.text);
        }

        public string Translate(string original)
        {
            return LanguageLocalizer.GetTranslation(original);
        }
    }
}
