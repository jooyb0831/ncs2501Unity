using System.Collections;
using System.Collections.Generic;
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
