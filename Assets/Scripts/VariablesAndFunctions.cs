using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt=5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplybyTwo(myInt);
        Debug.Log(myInt);
        Debug.LogError("Error!!");
    }

    int MultiplybyTwo(int number)
    {
        int result;
        result = number*2;
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("HelloWorld");
    }
}
