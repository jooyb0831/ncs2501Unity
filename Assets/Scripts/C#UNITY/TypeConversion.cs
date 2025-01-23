using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float i1 = 1;
        float f1 = i1;
        Debug.Log(f1);

        float x = 1.23f;
        int a = (int) x;

        byte[] bytes = {0,1,2,34};

        int k = BitConverter.ToInt32(bytes, 0);
        Debug.Log(k);

        string s1 = "12345";
        int str_int =int.Parse(s1); //문자열이 포함되어 있어도 가능은 함.

        string s2 = "123.45";
        float str_fl = float.Parse(s2);

        //TryParse :되는지 안 되는지 테스트. 변환값이 true/false
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
