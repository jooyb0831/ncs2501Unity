using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatchExample : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {


    }

    void Example4()
    {
        //go = new GameObject();
        try
        {
            Debug.Log(go.name);
        }
        catch (IndexOutOfRangeException ior)
        {
            //범위 및 크기초과
        }
        catch (DivideByZeroException dz)
        {
            //나누기 예외
        }
        catch(NullReferenceException ne)
        {
            Debug.Log(ne);
        }
        catch(Exception e) //그냥 Exception은 가장 큰 범위이므로 맨 마지막에 와야 함.
        {
            Debug.Log(e);
        }
        finally // 
        {
            Debug.Log("여기는 실행"); //
        }
        //위에 catch가 없고 에러나는 상황이면 실행 안 됨
        Debug.Log("끝");
    }

    void Example3()
    {
        //go = new GameObject();
        try
        {
            Debug.Log(go.name);

        }
        catch(Exception e) // 예외 발싱 새 Catch
        {
            Debug.Log(e);
        }
        finally // 
        {
            Debug.Log("여기는 실행"); //
        }
        //위에 catch가 없고 에러나는 상황이면 실행 안 됨
        Debug.Log("여기도 실행");
    }

    void Exmaple2()
    {
        //go = new GameObject();
        try
        {
            Debug.Log(go.name);

        }
        finally // 정상적일때는 그냥 실행됨.
        {
            Debug.Log("여기는 실행"); //
        }
        Debug.Log("여기는 실행 안됨");
    }

    void Example1()
    {
        try
        {
            Debug.Log(go.name);
        }

        catch (Exception ex)
        {
            Debug.Log(ex);
        }
        Debug.Log("여기도 실행");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
