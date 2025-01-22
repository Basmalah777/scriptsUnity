using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class CustomObject
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CustomObject(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }

        // Operator ==
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {

            if (ReferenceEquals(obj1, obj2))
                return true;

    
            if (ReferenceEquals(obj1, null) || ReferenceEquals(obj2, null))
                return false;


            return obj1.ID == obj2.ID && obj1.Name == obj2.Name;
        }

        // Operator !=
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return !(obj1 == obj2);
        }

        // Overriding GetHashCode to match equality logic
        public override int GetHashCode()
        {
            return (ID, Name).GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this == obj as CustomObject;
        }
    }
}