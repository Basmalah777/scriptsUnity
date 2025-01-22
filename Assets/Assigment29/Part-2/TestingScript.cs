using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TestingScript  : MonoBehaviour
    {
        CustomObject customObject;
        CustomObject customObject2;

        void Start()
        {
            customObject = new CustomObject(1, "Basmalah");
            print(customObject);

            customObject2 = new CustomObject(2, "Amr");
            print(customObject2);
            print($"Custom Object 1 == Custom Object 2 ? {customObject == customObject2}");

        }
    }
}
