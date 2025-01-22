using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        int x = 10;
        int y = 30;
        void Start()
        {
            print($"Recursive Fibonacci of {x} : {FibonacciRecursive(x)}");
            print($"Iterative Fibonacci of {x} : {FibonacciIterative(x)}");
            print($"Recursive Fibonacci of {y} : {FibonacciRecursive(y)}");
            print($"Iterative Fibonacci of {y} : {FibonacciIterative(y)}");
        }
        int FibonacciRecursive(int n)
        {
            if (n <= 1) return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            int num1 = 0;
            int num2 = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = num1 + num2;
                num1 = num2; 
                num2 = result;
            }
            return result;
        }
    }
}
