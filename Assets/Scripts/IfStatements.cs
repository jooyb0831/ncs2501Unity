using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemp = 85.0f;
    float hotLimitTemp = 70.0f;
    float coldLimitTemp = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TemperatuerTest();
            coffeeTemp -= Time.deltaTime * 5f;
        }
    }

    void TemperatuerTest()
    {
        //커피 온도가 가장 뜨거운 섭취 온도보다 높을 경우

        if(coffeeTemp > hotLimitTemp)
        {
            print("Coffee is too hot.");
        }

        else if(coffeeTemp < coldLimitTemp)
        {
            print("Coffee is too cold");
        }

        else
        {
            print("Coffee is just right");
        }
    }

}
