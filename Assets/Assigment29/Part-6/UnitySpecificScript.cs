using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        GameObject targetObject;
        GameObject joker;

        void OnEnable()
        {
            print("GameObject Enabled");
        }
        void Start()
        {
            print("Game started!");

            targetObject = GameObject.Find("TargetObject");

            if (targetObject != null)
                print($"Found object by name: {targetObject.name}");
            else
                print("No TargetObject found.");

            joker = GameObject.FindGameObjectWithTag("Joker");

            if (joker != null)
                print($"Found object by tag: {joker.name}");
            else
                print("No Joker object found.");


            Light lightObject = GameObject.FindObjectOfType<Light>();
            if (lightObject != null)
                print($"Found object of type Light: {lightObject.name}");
            else
                print("No Light object found.");

        }
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.D))
            {
                targetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
        }
        void OnDisable()
        {
            print("GameObject Disabled");
        }
    }
}