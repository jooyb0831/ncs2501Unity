using System.Diagnostics;
using UnityEngine;
using System;

namespace Hello
{
    public class NameSpaceDefintionExample
    {
        public void DebugLog(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        public static string StaticLog(string str)
        {
            return str;
        }
    }

    public class GetData
    {
        public static void GetDatas()
        {
            UnityEngine.Debug.Log("ㅠㅠ");
        }
    }
}