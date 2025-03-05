using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class CancellationTokenExample : MonoBehaviour
{
    CancellationTokenSource m_CTS;//CancellationTokenSource 클래스 필드에서 선언
    Task<int> m_Task;
    // Start is called before the first frame update
    void Start()
    {
        m_CTS = new CancellationTokenSource(); //CancellationTokenSource 객체를 생성
        CancellationToken ct = m_CTS.Token;
        m_Task = Task.Factory.StartNew(TaskMethod, ct); //m_CTS의 Cancel매서드를 호출해 작업 취소
        if(m_Task != null)
        {
            Debug.Log($"Count = {m_Task.Result}");
        }

    }
    
    private int TaskMethod()
    {
        int count = 0;
        for(int i = 0; i<10; i++)
        {
            if(m_CTS.Token.IsCancellationRequested) //비동기 작업 매서드 안에서 작업이 취소되었는지를 체크
            {
                break;
            }
            ++count;
            Thread.Sleep(1000);
        }
        return count;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            m_CTS.Cancel();

        }
    }
}
