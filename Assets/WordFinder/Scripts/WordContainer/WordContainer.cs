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

        [Header("# Settings")]
        [SerializeField] private int curLetterIndex;
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

        internal void Add(char obj)
        {
            letterContainers[curLetterIndex].SetLetter(obj);
            curLetterIndex++;
            if (curLetterIndex > letterContainers.Length - 1)
            {
                curLetterIndex = 0;
            }

        }

        internal bool InComplete()
        {
            return curLetterIndex > letterContainers.Length - 1;
        }

        internal string GetWord()
        {
            string s = "";

            for (int i = 0;i<letterContainers.Length;i++)
            {
                s += letterContainers[i].GetLetter();
            }

            return s;
        }
    }
}
