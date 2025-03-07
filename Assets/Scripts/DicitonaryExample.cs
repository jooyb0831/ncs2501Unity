using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DicitonaryExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1,"첫번째");
    
        bool result = dic.TryGetValue(0, out string str);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
