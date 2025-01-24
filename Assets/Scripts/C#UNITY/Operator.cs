using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using <네임스페이스>; system이라는 것을 쓰겠다.
//멤버 액세스 연산자 .(점)

public class Operator : MonoBehaviour
{
    //데이터 형식 변환 및 검사 연산자
    // is, as
    //typeof(int) : 
    // Start is called before the first frame update
    void Start()
    {
        int a = 1, b = 1;
        if (a != b)
        {
            Debug.Log("같지 않다.");
        }
        else
        {
            Debug.Log("같다.");
        }
        if (!(a == b))
        {
            Debug.Log("같지 않다.");
        }
        else
        {
            Debug.Log("같다.");
        }

        char c1 = 'a';
        char c2 = 'A';
        Debug.Log(c1.Equals(c2));
        a = 1 + 1 + 2 + 3;
        b = 6;
        Debug.Log($"ab계산 : {a != b}");
        Debug.Log($"ab계산 : {a.Equals(b)}");
        Debug.Log($"ab계산 : {!a.Equals(b)}");

        //E is T : E는 값을 반환하는 식이고 T는 데이터 형식.
        //is 연산자 : 식 결과의 런타임 데이터 형식이 지정된 형식과 호환하는지 확인
        int i = 1;
        object iBoxed = i;
        Debug.Log((iBoxed is int).ToString());
        Debug.Log((iBoxed is float).ToString());

        //E as T : as는 참조형 데이터 형식 간의 자료변환이 가능함.
        // 형변환이 가능하면 형변환수행, 그렇지 않으면 null을 대입.

        //typeof : 데이터 형식을 System.Type인스턴스를 가져옴
        float f1 = 1.569f;
        Debug.Log(typeof(float));
        Debug.Log(f1.GetType());

        //람다(Lambda) => : 메서드를 하나의 식으로 표현. 매개변수 목록과 시글 구분하는 연산자로 사용.
        //(매개변수-목록) => 식

        //delegate : 이름이 없는 무명 메서드를 만듦. 대리자 형식으로 변환될 수 있음.

        //new : 참조 형식의 인스턴스 생성.

    }

    void Old()
    {
        //sizeOf : 지정된 형식의 변수에서 사용하는 바이트 수를 반환.
        int intSize = sizeof(int);
        int fSize = sizeof(float);
        int bSize = sizeof(bool);
        int cSize = sizeof(char);
        //Debug.Log($"int : {intSize}, float : {fSize}, bool : {bSize}, char : {cSize}");


        int i = 1;
        Debug.Log($"before :{i}");
        Debug.Log($"++i :{++i}"); //앞에 있으므로 ++먼저 실행
        
        Debug.Log($"after : {i}");
        i = 1;
        Debug.Log($"before :{i}");
        Debug.Log($"i++ :{i++}"); //뒤에 있으면 뒤에 있기 때문에 해당 구문이 있는 문장을 먼서 실행하고 ++처리.
        Debug.Log($"after : {i}");

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
