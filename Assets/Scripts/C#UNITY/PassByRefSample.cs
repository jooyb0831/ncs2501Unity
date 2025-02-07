using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassByRefSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 1, b = 2;
        int c = 0; // 초기화
        bool b1 = RefMethod(a, b, ref c);
        bool bs = PassByValue(a,b,c);
        Debug.Log($"Value:{c}");
        Debug.Log($"{c}");
        int d = 3, e = 4;
        int f;//초기화하지 않음
        bool b2 = OutMethod(d, e, out f);

        List<int> list = new List<int>{1,2,3,4,5};
        var r = Average(list);


    }

    bool RefMethod(int a, int b, ref int c)
    {
        c = a + b;
        return true;
    }

    bool OutMethod(int d, int e, out int f) //초기화가 안 되어 있으면 out을 써야 함.
    {
        f = d + e;
        return true;
    }

    bool PassByValue(int a, int b, int c)
    {
        c = a+b;
        return true;
    }

    //튜플 : 한 번에 두 개의 값 리턴 가능함.
    (int count, float avg) Average(List<int> data)
    {
        int cnt = data.Count;
        int sum = 0;
        for(int i = 0; i<cnt; i++)
        {
            sum+=data[i];
        }
        float avrg = sum/cnt;

        return (cnt, avrg);
    }
}
