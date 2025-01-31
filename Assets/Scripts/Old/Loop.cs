using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ForeachLoop();
    }

    void ForLoop()
    {
        int numEnemies = 3;
        for (int i = 1; i <= numEnemies; i++)
        {
            Debug.Log("Creating enemy Number : " + i);
        }

        for(int i =numEnemies; i>=0; i--)
        {
            Debug.Log("minus for: "+i);
        }

        //무한루프...
        for(;;)
        {
            
        }

        int a = 0;
        for(int i = 0; i<10; i++) a++;
        
    }

    void WhileLoop()
    {
        int cupsIntheSink = 4;
        while(cupsIntheSink>0)
        {
            Debug.Log("I've wahsed a cup!");
            cupsIntheSink--;
        }

        //for문으로 쓰면
        cupsIntheSink = 4;
        for(int i = cupsIntheSink; i>0; i--)
        {
            Debug.Log("For : I've washed a cup!");
        }
    }

    void DoWhileLoop()
    {
        //Do-While : do{구문}-while{조건이 충족되면 do문 다시 실행}
        //반드시 한 번은 실행됨(최초에는 조건에 대한 판단이 실행되지 않음)
        //while은 조건이 먼저 오기 때문에 아예 실행되지 않을 수 있음.
        
        bool shouldContinue = false;

        do
        {
            print ("Hello World");
        } while(shouldContinue==true);

    }

    void ForeachLoop()
    {
        //Foreach는 자료구조(배열,리스트, 딕셔너리 등)과 자주 쓰임
        var strings = new string[3];
         
        strings[0] = "First String";
        strings[1] = "Second String";
        strings[2] = "Thrid String";

        foreach(var item in strings)
        {
            print(item);
        }

        //for문
        for(int i =0; i<strings.Length; i++)
        {
            print(strings[i]);
        }
    }

}
