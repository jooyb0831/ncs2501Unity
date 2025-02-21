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
    }
}
