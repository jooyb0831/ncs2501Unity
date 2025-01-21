using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //이 행은 오브젝트의 x 위치를 나타냅니다.

        /*
        안녕하세요
        여려줄 주석
        */

        Debug.Log(transform.position.x);

        if(transform.position.y<=5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
