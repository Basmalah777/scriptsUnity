using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            // Upcasting
            Cat catMeow = new Cat();
            Animal animal = catMeow;

            animal.MakeSound(); 
            animal.Move();     

            // Downcasting
            Cat catMeow2 = animal as Cat; 
            if (catMeow2 != null)
            {
                catMeow2.MakeSound();
                catMeow2.Move();
            }
            else
            {
                Debug.Log("Downcasting failed.");
            }

            // Type Checking
            List<ICanFight> canFights = new List<ICanFight> { new Cat(), new Warrior() };
            foreach (ICanFight canFight in canFights)
            {
                canFight.Attack();
            }

            foreach (ICanFight canFight in canFights)
            {
                switch (canFight)
                {
                    case Cat:
                        Debug.Log("The object is a Cat.");
                        break;
                    case Warrior:
                        Debug.Log("The object is a Warrior.");
                        break;
                }
            }
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }
        public void Move()
        {
            Debug.Log("Animal moves.");
        }
    }

    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
        public new void Move() 
        {
            Debug.Log("Cat runs quickly.");
        }
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }

    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }

    public interface ICanFight
    {
        void Attack();
    }
}

