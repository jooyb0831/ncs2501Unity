using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LambdaExample : MonoBehaviour
{
    //Action
    void ActionTest()
    {
        //Action _ 리턴값 없을 때
        Action a1 = () => Debug.Log("Action");
        a1();
        Action<int, int> a2 = (a, b) => Debug.Log($"{a},{b}");
        a2(2,3);
    }
    //Func, Action
    void Fucntest()
    {
        //Func<매개변수, 반환형식> // 리턴값이 있을 때 
        Func<int> func1 = () => 1;
        Debug.Log($"f1 : {func1()}");
        Func<int, int> func2 = (a) => a*2;
        Debug.Log($"f2 : {func2(1)}");
        Func<float, int> func3 = (f) => (int)f +3;
        Debug.Log($"f3 : {func3(1350.2f)}");
    }
    delegate int MyDelegate(int a, int b);
    // Start is called before the first frame update
    void Start()
    {
        MyDelegate myDelegate = (a, b) => { return (a + b); };
        MyDelegate myDelegate1 = (a, b) => a + b;
    }

    void AMethod()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
