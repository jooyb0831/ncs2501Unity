using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnumExample : MonoBehaviour
{
    enum EnumExample1 {e0, e1, e2}
    enum EnumExample2 {e0=5, e1, e2=10} // 값은 순서대로 넣어야 함(앞의 할당값보다 커야함)
    //열거형의 기본 형식은 int
    
    //열거자.ToString();

    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    enum Month : byte {Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec}


    // FlagEnum : enum의 각 열거자를 비트값으로 구성. 열거자기리 비트연산 사용.
    [Flags]
    enum Days
    {
        Sundauy = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32
    }



    // Start is called before the first frame update
    void Start()
    {
        Day today = Day.Wednesday;
        int dayNumber = (int)today;
        Debug.Log($"{today} is day number {dayNumber}");

        Month thisMonth = Month.Jan;
        byte monthNumber = (byte)thisMonth;
        Debug.Log($"{thisMonth} is month number {monthNumber}");

        Days WorkingDay = Days.Monday|Days.Tuesday|Days.Wednesday
        |Days.Thursday| Days.Friday;
        Debug.Log($"Workingdays are {WorkingDay}");

        Days today2 = Days.Wednesday;
        //오늘이 WorkingDay인지 판별하여 출력
        if((today2 & WorkingDay)==0) // 비트연산 &:비교 // 비교한 값이 0이면 같은 값이 없다.
        {
            Debug.Log("Today is a holiday");
        }
        else
        {
            Debug.Log("Today is a workingday");
        }

        if(!WorkingDay.HasFlag(today2))
        {
            Debug.Log("Today is a holiday");
        }
        else
        {
            Debug.Log("Today is a workingday");
        }

    }

    enum GameState
    {
        Ready,
        Play,
        GameOver
    }
    void GameStateCheck()
    {
        //GameState enum
        GameState gameState = GameState.Ready;

        if (gameState.Equals(GameState.Ready))
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
