using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{   
    string[] DCComics = new string[4];
    string[] Avengers = new string[]{"Iron Man", "Captain America", "Spider Man"};
    
    string[,] Heores = new string[2,3];
    // Start is called before the first frame update
    void Start()
    {
        string[,] Heroes1 = new string[2, 3] { { "Iron", "Cap", "Spider" }, { "Super", "Bat", "Wonder" } };
        string[,] Heroes2 = new string[,] { { "IN", "CA", "SM" }, { "SM", "BM", "WM" } };
        var Heores3 = new string[,] { { "IN", "CA", "SM" }, { "SM", "BM", "WM" } };
        var Heors4 = new string[,,] {{{""},{""}}, {{""},{""}}, {{""},{""}}};
        DCComics[0] = "Super Man";
        DCComics[1] = "Bat Man";
        DCComics[2] = "Aqua Man";
        DCComics[3] = "Wonder Woman";

        string str = Heroes1[0,0];

        //가변배열
        string[][] NewHeroes = new string[2][]; //앞에 행만 크기 지정.
        NewHeroes[0] = new string[3]{ "IN", "CA", "SM" };
        //NewHeroes[1] = new string[4]{ "SM", "BM", "AM", "WM"}; //행은 두 행이지만 각각의 열은 3행, 4행.
        //가변배열은 [,]가 아니라 [][]로 써야 함.
        
        string[][] NewHeroes2 = new string[][] // var로도 가능
        {
            new string[]{"Iron", "Captain", "Spider"},
            new string[]{"Super","Bat","Aqua","Wonder"}
        };

        string[][] NewHeroes3 =
        {
            new string[]{"Iron", "Captain", "Spider"},
            new string[]{"Super","Bat","Aqua","Wonder"}
        };
        Debug.Log($"2차원배열 : {Heroes2[1,1]}");
        //Debug.Log($"가변배열 : {NewHeroes[1][1]}");
        Debug.Log(Heroes1.Rank);
        //다차원 배열의 크기 얻기 : GetLength(n:차원수);
        
        //다차원 배열을 일차원 배열로 바꾸기
        TwoArrayToOneArray();

    }

    void TwoArrayToOneArray()
    {
        
        int[,] twoArray = new int[,]{{1,2},{3,4},{5,6}};
        int[] oneArray = new int[twoArray.GetLength(0)*twoArray.GetLength(1)];
        for(int i = 0; i<twoArray.GetLength(0); i++)
        {
            for(int j = 0; j<twoArray.GetLength(1); j++)
            {
                oneArray[(twoArray.GetLength(1)*i)+j] = twoArray[i,j];
            }
        }

        string str = "";
        for(int i = 0; i<oneArray.Length; i++)
        {
            str+=oneArray[i].ToString()+", ";
        }

        Debug.Log($"oneArray = [{str}]");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
