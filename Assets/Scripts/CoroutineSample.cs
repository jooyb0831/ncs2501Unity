using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSample : MonoBehaviour
{
    private IEnumerator m_Coroutine;

    public static readonly WaitForSeconds m_waitForSeconds2s = new WaitForSeconds(2f); // 캐싱
    private bool m_IsBreak;
    private bool m_IsCorutineing;
    // Start is called before the first frame update
    void Start()
    {
        m_Coroutine = CoroutineMethod();
        StartCoroutine(m_Coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(m_Coroutine);
        }
        
        if(m_IsCorutineing)
        {
            Debug.Log("코루틴이 실행 전이거나 종료됨.");
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
           // StopCoroutine(m_Coroutine); //일시정지
           //m_IsBreak = true; // 무한반복문 종료
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            StopAllCoroutines(); //완전히 정지
        }
    }

    IEnumerator CoroutineMethod()
    {
        int count = 0;
        while (true)
        {
            Debug.Log(count);
            yield return m_waitForSeconds2s; //사용
            count ++;
        }
        /*
        m_IsCorutineing = true;
        Debug.Log("시작");
        yield return new WaitForSeconds(1.0f);
        Debug.Log("종료");
        m_IsCorutineing = false;
        */
        /*
        int count = 0;

        while(!m_IsBreak)
        {
            Debug.Log(count);
            yield return new WaitForSeconds(1.0f);
            count ++;
        }
        */
    }
}
