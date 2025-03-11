using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class ThreadDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Thread thread = new Thread(Run6);
        thread.Start();

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"Main Thread : {i}");
            Thread.Sleep(100);
        }
        thread.Abort();
        Debug.Log("Main Thread End");
    }

    void Run6()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Sub-Thread : {i}");
            Thread.Sleep(100);
        }
    }

    void ThreadPoolVoid()
    {
        ThreadPool.QueueUserWorkItem(Run5);
        ThreadPool.QueueUserWorkItem(Run5, 1);
        ThreadPool.QueueUserWorkItem(Run5, 2);
    }

    static void Run5(object obj)
    {
        Debug.Log(obj);
    }

    void ThreadWait()
    {
        EventWaitHandle eventWaitHandle = new EventWaitHandle(false, EventResetMode.ManualReset);

        Thread thread = new Thread(Run4);
        thread.Start(eventWaitHandle);
        Debug.Log("서브 스레드 시작");

        for (int i = 0; i < 1; i++)
        {
            Debug.Log($"Main Thread : {i}");
            Thread.Sleep(100);
        }

        eventWaitHandle.WaitOne();
        Debug.Log("Main Thread Ends");
    }
    static void Run4(object obj)
    {
        EventWaitHandle eventWaitHandle = obj as EventWaitHandle;

        for (int i = 0; i < 1; i++)
        {
            Debug.Log($"Sub-Thread : {i}");
            Thread.Sleep(100);
        }
        Debug.Log("Sub-Thread Ends");
        eventWaitHandle.Set();
    }
    void JoinThread()
    {
        Thread thread = new Thread(Run3);
        thread.Start();

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"메인 스레드 : {i}");
            Thread.Sleep(100);
        }
        thread.Join();
        Debug.Log("메인 스레드 종료");
    }

    static void Run3()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"서브스레드 : {i}");
            Thread.Sleep(100);
        }
        Debug.Log("서브 스레드 종료");
    }
    void Memo1()
    {
        Thread thread = new Thread(Run2);
        thread.IsBackground = true;
        thread.Start(1);

        Thread thread1 = new Thread(() => Sum(1, 2, 3));
        thread.Start();
    }

    static void Sum(int d1, int d2, int d3)
    {
        int sum = d1 + d2 + d3;
        Debug.Log(sum);
    }
    static void Run2(object obj)
    {
        Debug.Log(obj);
    }


    void Run()
    {
        Debug.Log($"Thread#{Thread.CurrentThread.ManagedThreadId} : 시작");
        Thread.Sleep(1000);
        Debug.Log($"Thread#{Thread.CurrentThread.ManagedThreadId} : 종료");
    }


    void Memo()
    {
        //Thread thread = new Thread(Run);
        //Thread thread = new Thread(new ThreadStart(Run));
        //Thread thread = new Thread(() => Run());
        /*
        Thread thread=new Thread(delegate()
        {
            Run();
        });
        thread.Start();
        */
        new Thread(() => Run()).Start();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
