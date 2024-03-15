using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace U7_HC
{
    public class KeyboardKey : MonoBehaviour
    {
        [Header("# Setting")]
        [SerializeField] private TextMeshProUGUI letterText;

        [Header("# Event")]
        public static Action<Char> onKeyPressed;

        private void Awake()
        {
            letterText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(SendPressedEvent);
        }

        private void SendPressedEvent()
        {
            onKeyPressed?.Invoke(letterText.text[0]);
        }
    }
}
