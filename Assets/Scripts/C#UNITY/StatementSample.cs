using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementSample : MonoBehaviour
{
    enum EAvengers{IronMan, SpiderMan, Hulk}
    // Start is called before the first frame update
    void Start()
    {
        EAvengers avengers = EAvengers.IronMan;

        switch(avengers)
        {
            case EAvengers.IronMan :
            case EAvengers.SpiderMan:
            case EAvengers.Hulk:
                Debug.Log(avengers);
                break;
            
            default :
                break;
            
        }
        //int i1 = 1, i2=2;
        //if(i1<i2) Debug.Log("True");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
