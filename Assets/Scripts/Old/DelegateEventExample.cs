using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DelegateEventClass
{
    public delegate void DelegateMethod(string message);
    public event DelegateMethod EventMethod;

        public void MultipleOf5(int number)
    {
        if(number %5 == 0 && number != 0)
        {
            EventMethod($"{number}는 5의 배수");
        }
    }
}

public class DelegateEventExample : MonoBehaviour
{

    int sum = 0;
    // Start is called before the first frame update
    void Start()
    {
        DelegateEventClass delegateEventClass = new DelegateEventClass();
        delegateEventClass.EventMethod += DebugLog;
        for(int i = 0; i< 30; i++)
        {
            delegateEventClass.MultipleOf5(i);
        }
        Debug.Log($"5의 배수의 개수 : {sum}개");
    }

    void DebugLog(string message)
    {
        sum++;
        Debug.Log($"{message}, sum : {sum}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
