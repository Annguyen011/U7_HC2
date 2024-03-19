using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U7_HC
{
    public class WordManager : MonoBehaviour
    {
        public static WordManager instance;

        [Header("# Elements")]
        [SerializeField] private string secretOrd;

        private void Awake()
        {
            instance = this;
        }

        public string GetSecretOrd()
        {
            return secretOrd.ToUpper();
        }
    }
}
