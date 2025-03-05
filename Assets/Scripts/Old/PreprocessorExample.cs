#if UNITY_ANDROID
    #define Define1
#else 
    #undef Define1 
    #define Define2
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreprocessorExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if (Define1 && !Define2)
        Debug.Log("Define1 is defined");
#elif (!Define1 && Define2)
        Debug.Log("Define2 is defined");
#elif(Define1 && Define2)
        Debug.Log("Define1 and Define2 are defined");
#else   
        Debug.Log("Define1 and Define2 are not defined")
#endif
    }


    void PreProcessProperty()
    {
#if(UNITY_EDITOR || UNITY_STANDALONE_WIN || UNITY_IOS || UNITY_ANDROID)
    {

    }
#endif

#region PlatforDivide
#if (UNITY_STANDALONE_WIN)
    #region UNITY
    #if (UNITY_EDITOR)
        Debug.Log("Input Manager");
    #else
        Debug.Log("Input Manager");
    #endif
    #endregion UNITY
#elif(UNITY_ANDORID)
    #if(UNITY_DEITOR)
        Debug.Log("Input System");
    #else
        Debug.Log("Input System");
    #endif
#endif
#endregion
    }
}
