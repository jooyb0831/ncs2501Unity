using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int par1 = 1, par2 = 2;
        int intMethod = IntMethod(par1, par2);
        Debug.Log(intMethod);

        float par3 = 1.2f;
        VoidMethod(par3);
    }

    int IntMethod(int p1, int p2)
    {
        return (p1+p2);
    }

    void VoidMethod(string message)
    {
        Debug.Log(message);
        return; // 생략가능
    }

    void VoidMethod(float f1)
    {
        Debug.Log($"Float : {f1}");
    }


}
