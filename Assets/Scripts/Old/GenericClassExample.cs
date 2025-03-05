using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample : MonoBehaviour
{
    public class GenericsClass<T>
    {
        private T value;

        public GenericsClass(T value)
        {
            this.value = value;
        }

        public void Method()
        {
            Debug.Log(value);
        }
    }

    void Start()
    {
        GenericsClass<int> gc1 = new GenericsClass<int>(5);
        gc1.Method();

        GenericsClass<float> gc2 = new GenericsClass<float>(5.1f);
        gc2.Method();

        GenericsClass<string> gc3 = new GenericsClass<string>("Start!");
        gc3.Method();

        int x = 1, y = 2;
        Debug.Log($"바뀌기 전 X의 값 : {x}, Y의 값 : {y}");
        Swap(ref x, ref y);
        Debug.Log($"X의 값 : {x}, Y의 값 : {y}");

        string a = "ab", b = "cd";
        Debug.Log($"바뀌기 전 A의 값 : {a}, B의 값 : {b}");   
        Swap(ref a, ref b);
        Debug.Log($"A의 값 : {a}, B의 값 : {b}");   
    }

    void Swap<T>(ref T x, ref T y)
    {
        var temp = y;
        y = x;
        x = temp;
    }
}
