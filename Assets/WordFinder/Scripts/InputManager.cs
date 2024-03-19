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

        private void Start()
        {
            ordContainer = FindObjectsOfType<WordContainer>();

            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < ordContainer.Length; i++)
            {
                ordContainer[i].Initialize();
            }
        }
    }
}
