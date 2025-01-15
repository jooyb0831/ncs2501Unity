using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //var는 값 선언해야 함.
        var i =1;
        var f= 2f;

        //한 줄로 선언 할 수 있음
        int age = 45, brother=2;
        int i1, i2=5, i3;

        //단 var는 한줄로 쓰기 불가능
        // var v1 =1, v2=2; ->에러

        //참조 형식은 new 연산자 사용
        string str = new string("abc");
        string str2 = "abc";

        int num1;
        num1 =2;
        
        int num2 = 2;
        float num3 = 3, num4 = 4;

        bool isBool = true;
        Debug.Log(num1.ToString());
        Debug.Log(num2.ToString());
        Debug.Log(num3.ToString());
        Debug.Log(num4.ToString());
        Debug.Log(isBool.ToString());

        //전역변수에 값을 할당하지 않고 사용하면 초기값이 자동으로 할당됨.
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
