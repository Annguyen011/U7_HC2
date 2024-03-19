using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace U7_HC
{
    public class LetterContainer : MonoBehaviour
    {
        [Header("Elements")]
        [SerializeField] private TextMeshPro letter;

        // Start is called before the first frame update
        void Awake()
        {
            letter = GetComponentInChildren<TextMeshPro>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        
        internal void Initialize()
        {
            letter.text = "";
        }

        internal void SetLetter(char obj)
        {
            letter.text = obj.ToString();
        }

        internal string GetLetter()
        {
            return letter.text;
        }
    }
}
