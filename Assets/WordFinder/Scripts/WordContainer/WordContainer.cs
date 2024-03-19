using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U7_HC
{
    public class WordContainer : MonoBehaviour
    {
        [Header("# Elements")]
        [SerializeField] private LetterContainer[] letterContainers;

        private void Awake()
        {
            letterContainers = GetComponentsInChildren<LetterContainer>();
            //Initialize();
        }

        public void Initialize()
        {
            for (int i = 0; i < letterContainers.Length; i++)
            {
                letterContainers[i].Initialize();
            }
        }
    }
}
