using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using UnityEngine;

public class Class1
{
    public static int staticInt = 5;
    public int m_IntVariable;
    private string m_StringVariable;

    private int proprerty;
    public int Property
    {
        get { return proprerty;}
        set {proprerty = value;}
    }
    
    public int Property1{get;set;}

    public int Property2{get; private set;}

    public Class1()
    {
        
    }

    public Class1(int num)
    {
        m_IntVariable=num;
    }

    public static void StaticVoid()
    {
        staticInt ++;
        //m_IntVariable ++; Static함수의 경우 Static 변수만 사용가능.
    }

    public void DebugLog(string message)
    {
        m_StringVariable = message;
        Debug.Log(message);
        Debug.Log(m_IntVariable);
    }
}
public class ClassExample : MonoBehaviour
{
    private int num;
    private Class1 m_Class1 = new Class1();
    private Class1 m_Class2 = new Class1(100);

    [SerializeField] private int num1;
    public int Num2
    {
        get{return num1;}
        set{num1=value;}
    }
    // Start is called before the first frame update
    void Start()
    {
        m_Class1.DebugLog("Example");
        m_Class2.DebugLog("class2");
        Class1.staticInt = 1; //인스턴스를 통해 접근할 수는 없음.
        num = Class1.staticInt;
        Class1.StaticVoid();
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
