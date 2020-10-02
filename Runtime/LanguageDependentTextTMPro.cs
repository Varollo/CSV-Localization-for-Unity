﻿using UnityEngine;
using TMPro;

namespace Varollo.Localization
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class LanguageDependentTextTMPro : MonoBehaviour
    {
        private TextMeshProUGUI _text;

        private void Start()
        {
            _text = GetComponent<TextMeshProUGUI>();

            _text.text = LanguageLocalizer.GetTranslation(_text.text);
        }
    }
}