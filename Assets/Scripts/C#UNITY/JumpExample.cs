using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpExample : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    void GOTOJump()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                goto label; //i 가 3이 되면 for문을 벗어나서 label로 이동.
            }
            Debug.Log(i);
        }

        Debug.Log("upperLabel");


    label: //라벨. 이름 수정 가능.
        Debug.Log($"last");
    }

    /// <summary>
    /// Continue
    /// </summary>
    void ContinueJump()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i<7)
            {
                Debug.Log($"i:{i}");
                continue;
                Debug.Log("Under Continue"); //안찍힘
            }

            Debug.Log(i);
        }
    }


    /// <summary>
    /// Switch문에서의 Break 활용
    /// </summary>
    void SwitchBreak()
    {
        int n = 2;
        switch (n)
        {
            case 1:
                Debug.Log("1");
                break;

            case 2:
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == 2)
                        {
                            break;
                        }
                        Debug.Log($"n:{n}, i:{i}");
                    }

                    Debug.Log("2");
                    break;
                }
            default:
                Debug.Log("default");
                break;
        }
    }

    /// <summary>
    /// For문에서Break 활용
    /// </summary>
    void ForBreak()
    {
        for (int k = 0; k < 2; k++)
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break; //가장 가까운 for문을 빠져나옴.
                }
                Debug.Log($"k:{k}, i{i}");
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
