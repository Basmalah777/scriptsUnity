using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{

    public class TestUtilities : MonoBehaviour
    {
        void Start()
        {
            Debug.Log($"Total Number: {Utilities.Add(1, 2, 3, 4, 5)}");
            Debug.Log($"Repeated Text: {"Basmalah ".RepeatString(6)}");
        }
    }
}
