using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using Debug = UnityEngine.Debug;

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
        //Debug.Log("abcde:" + abCde);

        //int, float 등은 원래 null값을 넣을 수 없음. 다만 Nullable<T>와 ?를 사용하면 가능
        int? ii = null;

        TimeSpan();

        
    }

    void LocalVariable(int parameter /*매개변수*/)
    {
        float localVariable = parameter; // 지역변수
    }


    void TimeSpan()
    {
        //DateTime : Using System 필수
        DateTime dt = new DateTime(2025, 01, 17, 14, 14, 14);
        //Debug.Log(dt);

        //TimeSpan : 시간의 간격을 나타내는 구조체. DateTime 나타내기 위해
        //2개의 DateTime을 빼면 TimeSpan 값을 얻을 수 있음.
        DateTime dateTime1 = new DateTime(2018,08,1,2,3,4);
        DateTime dateTime2 = new DateTime(2019,10,20,12,0,5);
        TimeSpan timeSpan = dateTime2 - dateTime1;


        Debug.Log(timeSpan.Days.ToString());
        Debug.Log(timeSpan.Hours.ToString()); //숫자상 시간만 비교
        Debug.Log(timeSpan.Minutes.ToString());
        Debug.Log(timeSpan.Seconds.ToString());
        Debug.Log(timeSpan.TotalHours.ToString()); //실제 지나간 시간을 체크함
        Debug.Log(timeSpan.TotalMinutes.ToString());
    }

    void StopWatchVoid()
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Reset(); // 다시 시간을 0으로 리셋함
        stopWatch.Start(); // 스탑워치 시작
        //stopWatch.ElapsedMilliseconds();
        Debug.Log(stopWatch);
    }

    
}
