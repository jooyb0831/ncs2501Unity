using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormatExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("I am {0}. I am {1} years old.", "Iron Man", 55);
        Debug.Log($"I am {"IronMan"}. I am {55} years old");
        Debug.LogFormat("I am {0}. I am {1}years old.","Super Man", 100);
        Debug.LogFormat("I am {0}. You are not {0}.", "Thor");

        float value1 = 123;
        //0 : 해당 숫자가 있을 경우 0을 해당 숫자로 바꾸고, 그렇지 않으면 문자열에 0을 표시함
        //# : 해당 숫자가 있을 경우 #을 해당 숫자로 바꾸고, 없으면 문자열에 숫자 표시 안함.

        Debug.Log(value1.ToString("00000"));
        Debug.Log(string.Format("value1 is {0:00000}", value1));

        Debug.Log(value1.ToString("#####"));
        Debug.Log(string.Format("value1 is {0:#####}", value1));

        float value2 = 1.23f;
        Debug.Log(value2.ToString("0.0"));
        Debug.Log(string.Format("value2 is {0:0.00}", value2));

        float value3 = 1234567890;
        Debug.Log(value3.ToString("#,#"));
        Debug.Log((string.Format("value3 is {0:#,#}", value3)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
