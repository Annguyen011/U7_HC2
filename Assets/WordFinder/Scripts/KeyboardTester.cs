using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace U7_HC
{
    public class KeyboardTester : MonoBehaviour
    {
        private void Start()
        {
            KeyboardKey.onKeyPressed += DebugTester;
        }

        private void DebugTester(char letter)
        {
            print(letter);
        }
    }
}
