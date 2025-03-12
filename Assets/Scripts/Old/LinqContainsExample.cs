using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

class Avengers
{
    public string Name { get; set; }
    public string[] Weapon { get; set; }
}
public class LinqContainsExample : MonoBehaviour
{
    List<Avengers> avengers = new List<Avengers>
    {
        new Avengers {Name = "Iron Man", Weapon = new string[]{"Mk.01", "Mk.44", "Mk.85"}},
        new Avengers {Name = "Thor", Weapon = new string[]{"Mjolnir", "Storm Breaker"}},
        new Avengers {Name = "Captain America", Weapon = new string[]{"Mjolnir", "Shield"}}
    };

    // Start is called before the first frame update
    void Start()
    {
        //All
        IEnumerable <string> names = from hero in avengers
                            where hero.Weapon.All(item => item.Length == 5) //All : 모든 조건 만족하는지!
                            select hero.Name;
        string strs = "(ALL)모든 Weapon의 글자 길이 5인 영웅(Name)들 : ";
        DebugLog(strs, names);

        //Any
        names = from hero in avengers
                where hero.Weapon.Any(item => item.StartsWith("M"))
                select hero.Name;
        strs = "(ANY)Weapon이 'M'으로 시작하는 어느 하나라도 있는 영웅들 : ";
        DebugLog(strs, names);

        //Contains
        names = from hero in avengers
                where hero.Weapon.Contains("Mjolnir")
                select hero.Name;
        strs = "(Contains) Weapon에 묠니르를 갖고 있는 영웅들 : ";
        DebugLog(strs, names);

    }

    void DebugLog(string strs, IEnumerable names)
    {
        foreach(string name in names)
        {
            strs += $"{name}, ";
        }
        Debug.Log(strs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
