using System.Collections;
using System.Collections.Generic;
using UnityEngine; //클래스가 아니고 네임스페이스 써야힘
using Hello;
using Debug = UnityEngine.Debug;
using GetData = Hello.GetData;


public class NamespaceExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var ns = new NameSpaceDefintionExample();
        ns.DebugLog("dkss");
        string str = NameSpaceDefintionExample.StaticLog("s");
    }
    // Update is called once per frame
    void Update()
    {
        GetData.GetDatas();
    }


}