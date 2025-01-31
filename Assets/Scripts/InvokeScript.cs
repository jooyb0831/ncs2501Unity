using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class InvokeScript : MonoBehaviour
{
    public enum State
    {
        Make,
        Stop
    }

    State state = State.Make;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects",2,1);
        state = State.Make;

    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            switch (state)
            {
                case State.Stop:
                {
                    InvokeRepeating("SpawnObjects", 0, 1);
                    state = State.Make;
                    break;
                }
                case State.Make:
                {
                    CancelInvoke("SpawnObjects");
                    state = State.Stop;
                    break;
                }
            }
        }

       
    }

    void SpawnObject()
    {
        Instantiate(target, new Vector3(0,3,0), Quaternion.identity);
    }

    void SpawnObjects()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x,3,z), Quaternion.identity);

     //Random.Range() int -> 최소값은 범위 포함, 최대값은 포함X
     //float일 경우 Max도 포함됨.
    }
}
