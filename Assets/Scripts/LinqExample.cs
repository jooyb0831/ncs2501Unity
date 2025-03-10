using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Search;
using System;

public class LinqExample : MonoBehaviour
{
    string[] avengers = {"Iron Man", "Captain America", " Thor", "Hulk", "Black Panther", "Spider Man"};
    // Start is called before the first frame update
    void Start()
    {
        //OrderBy();
        //Distinct();
        //Except();

        Querry_Where();
    }

    void OrderBy()
    {
        string strs = String.Empty;
        IEnumerable<string> query = from hero in avengers
                            orderby hero.Length //글자의 크기 작은 순 -> 긴 순 정렬
                            select hero;
        strs = "글자 길이 순 정렬 : ";
        foreach(string str in query)
        {
            strs += $"{str}, ";
        }
        Debug.Log(strs);
        //OrderbyDescending
        query = from hero in avengers
                orderby hero.Substring(0,1) descending
                select hero;
        strs = "0번 인덱스 내림차순 정렬 : ";
        foreach(string str in query)
        {
            strs += $"{str}, ";
        }
        Debug.Log(strs);

        query = from hero in avengers
                orderby hero.Length, hero.Substring(0,1)
                select hero;
        strs = "길이순, 앞글자순 정렬 : ";
        foreach(string str in query)
        {
            strs += $"{str}, ";
        }
        Debug.Log(strs);

        query = from hero in avengers
                orderby hero.Length, hero.Substring(0,1) descending
                select hero;
        strs = "길이순, 앞글자 내림차순 정렬: ";
        foreach(string str in query)
        {
            strs += $"{str}, ";
        }
        Debug.Log(strs);

    }

    void Distinct()
    {
        string [] avengers1 = {"Iron Man", "Iron Man", "Captain America", "Thor"};
        IEnumerable<string> query = from hero in avengers1.Distinct()
                                    select hero;
        
        string strs = "중복제거 : ";
        foreach (string str in query)
        {
            strs += $"{str}, ";
        }
        Debug.Log(strs);

    }

    void Except()
    {
        string[] avengers21 = {"Iron Man", "Captain America", "Thor"};
        string[] avengers22 = {"Iron Man", "Hulk", "Captain America"};
        
        IEnumerable<string> query = from hero in avengers21.Except(avengers22)
                                    select hero;
        string strs = "교집합 제거 : ";
                foreach (string str in query)
        {
            strs += $"{str}, ";
        }
        Debug.Log(strs);

    }
    string DebugLog(string str)
    {
        return $"{str}, ";
    }

    void Querry_Where()
    {
        IEnumerable<string> query = from hero in avengers
                                    where hero.Length == 4 //길이가 4인 애들 찾음
                                    select hero;
        string strs = $"글자 길이가 4인 애들 찾기 : ";
        foreach (string str in query)
        {
            strs += $"{str}, ";
        }
        Debug.Log(strs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
