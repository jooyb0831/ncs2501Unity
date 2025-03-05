using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate int CalculateDelegate(int a, int b); //접근제한자 delegate데이터-형식 델리게이트-이름(매개-변수)

    delegate T CalcualteDelegate1<T>(T a, T b);
    // Start is called before the first frame update
    void Start()
    {
        CalculateDelegate Plus = new CalculateDelegate(Add); 
        //CalculateDelegate Minus = Substract;
        CalculateDelegate cd = Add;
        //cd += Subtract;
        //cd(3,2);

        Plus += Add; 
        Plus += Subtract;
        DebugLog(1,2, Plus); //DebugLog 값은 제일 마지막 값을 따름..
        //값이 계속 쌓이지 않음.

        //CalcualteDelegate1<int> Plus1 = new CalcualteDelegate1<int>(Add);
        
        //DebugLog(1,2, Plus);
        //DebugLog(1,2, Add);
        //DebugLog(4,3, Substract);
        //DebugLog(4,3, Minus);
    }

    void DebugLog(int a, int b, CalculateDelegate cd)
    {
        Debug.Log(cd(a, b)); 
    }

    int Add(int a, int b)
    {
        Debug.Log($"Add : {a}+{b} = {a+b}");
        return a+b;
    }

    int Subtract(int a, int b)
    {
        Debug.Log($"Add : {a}-{b} = {a-b}");
        return a-b;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
