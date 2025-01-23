using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class StringSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string msg1 = "message1";
        string msg2 = null; // 값이 없음(null로 초기화)
        string msg3 = ""; // 빈칸으로 초기화한 것
        string msg4 = string.Empty; //=""; 빈칸으로 초기화한 것

        string name = "CoderZero";
        char[] charArrays = name.ToCharArray();//문자열을 char의 배열로 변환함
        //Debug.Log(charArrays[1]);

        char[] charArray ={'A','B','C'};
        string s = new string(charArray);
        //Debug.Log(s);

        //StringBuilders
        StringBuilder sb = new StringBuilder("stringbuilder");
        sb.Append("stringbuilder");
        
        var sb1 = new StringBuilder("Coder ");
        sb1.Append("Zero");
        Debug.Log(sb1);

        var sb2 = new StringBuilder("Unity #");
        sb2.Insert(6,"C");//n번째 인덱스에 "문자열" 삽입
        Debug.Log(sb2);

        var sb3 = new StringBuilder("Coder Zero");
        sb3.Remove(6,3); //n번째 인덱스부터 n+m-1번째 인덱스까지 삭제
        Debug.Log(sb3);

        var sb4 = new StringBuilder("Coder zero");
        sb4.Replace('z','Z'); //소문자 z를 Z로(문자열 전체)
        Debug.Log(sb4);

        var sb5 = new StringBuilder("Coder Zero Visual C#");
        sb5.Replace("Visual", "Unity");//정확히 해당 문자열이여야 바뀜.
        Debug.Log(sb5);

        var sb6 = new StringBuilder("Couder Zero unity C#");
        sb6.Replace('u','U',0,13); //소문자 u 를 대문자 U로 변경.(시작 인덱스에서 count_길이)
        Debug.Log(sb6);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
