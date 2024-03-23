using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U7_HC
{
    public class InputManager : MonoBehaviour
    {
        [Header("# Elements")]
        [SerializeField] private WordContainer[] ordContainer;

        [Header("# Settings")]
        int currentContainer;

        private void Awake()
        {
            ordContainer = FindObjectsOfType<WordContainer>();
        }

        private void Start()
        {
            Initialize();

            KeyboardKey.onKeyPressed += KeyPressedCallBack;
        }

        private void KeyPressedCallBack(char obj)
        {
            if (ordContainer[currentContainer].InComplete())
            {
                CheckOrd();
            }

            ordContainer[currentContainer].Add(obj);
        }

        private void Initialize()
        {
            for (int i = 0; i < ordContainer.Length; i++)
            {
                ordContainer[i].Initialize();
            }
        }

        public void CheckOrd()
        {
            string ordRes = WordManager.instance.GetSecretOrd();
            string ordToCheck = ordContainer[currentContainer].GetWord();

            if (ordRes.Equals(ordToCheck))
            {
                print("Finish");

            }
            else
            {
                currentContainer++;
            }
        }
    }
}
