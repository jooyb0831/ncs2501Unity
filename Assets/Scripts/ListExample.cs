using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> list = new List<string>();

        list.Add("첫번째");
        list.Add("두번째");
        list.Add("셋번째");
        list.Add("넷번째");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
