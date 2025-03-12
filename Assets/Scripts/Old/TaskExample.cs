using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;

public class TaskExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void GenericTaskTest()
    { 
        //일반 Task는 반환값을 받지 못하지만 제네릭 Task를 사용하면 변환값 얻을 수 있음.
        //Result 라는 속성으로 변환값 얻어옴.
        Task<int> task = Task.Factory.StartNew<int>( () => GetSize("GenericTask"));
        int result = task.Result;
        Debug.Log(result);
    }

    int GetSize(string data)
    {
        return data.Length;
    }

    void TaskCheck()
    {
        Task.Factory.StartNew(() => { Debug.Log("Task"); }); // 직접 호출, 스레드 생성과 시작
        Task task2 = new Task(new Action(DebugLog)); //Action대리자
        task2.Start(); // Task 스레드 시작 

        Task task3 = new Task(delegate { DebugLog(); }); //대리자
        task3.Start();

        Task task4 = new Task(() => { DebugLog(); }); // 람다와 익명 매서드
        task4.Start();

        Task task5 = new Task(() => DebugLog()); // 람다식
        task5.Start();


        task2.Wait(); // Task가 끝날 때까지 대기
        task3.Wait(); // Task가 끝날 때까지 대기
        task4.Wait(); // Task가 끝날 때까지 대기
        task5.Wait(); // Task가 끝날 때까지 대기
    }

    void DebugLog()
    {
        Debug.Log("Task");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
