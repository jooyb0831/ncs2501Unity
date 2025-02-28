using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonymousType : MonoBehaviour
{
    delegate int MyDelegate(int a, int b);
    // Start is called before the first frame update
    void Start()
    {
        var t = new {name = "Coderzero", age = 47};
        Debug.Log($"name : {t.name}, age : {t.age}");
         
    MyDelegate sum;
    sum = Amethod;

    sum = delegate( int a, int b) //이름 짓지 않고 바로 실행.
    {
        return a+b;
    }; //세미콜론필수
    }

    private int Amethod(int a, int b)
    {
        return a*b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
