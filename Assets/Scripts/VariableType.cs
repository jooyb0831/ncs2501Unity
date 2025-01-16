using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class VariableType : MonoBehaviour
{

    //필드

    public bool staticVariable = true; //정적변수
    private int m_GlobalVariable = 1; //전역변수
    public int abCde = 4; //인스펙터상에는 처음 입력한 값으로 나오고 실행값도 Script에 있는 값이 아닌 인스펙터상 값.
    //적용하려면 reset누르면 됨.
    public string STR = "hello";

    // readonly : Const와 비슷하지만 런타임시 사용, static은 아니지만 static으로 선언가능. 지역변수/함수안에서 선언 불가
    // const : 컴파일 시, static.


    // Start is called before the first frame update
    void Start()
    {
        int localVariable1 = 1; // 지역변수
        int localVariable2; // 값을 할당하지 않은 지역변수
        //Debug.Log(localVariable2.ToString()); // 에러
        LocalVariable(1 /*매개변수*/);
        Debug.Log("abcde:" + abCde);
        
    }

    void LocalVariable(int parameter /*매개변수*/)
    {
        float localVariable = parameter; // 지역변수
    }
}
