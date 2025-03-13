using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


[Serializable]
public class JsonData
{
    public string name;
    public int age;
    public float height;
    public bool man;
    public string description;
    public string[] tools;
}
public class JsonExample : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        JsonData[] jsonData = new JsonData[2];
        jsonData[0] = new JsonData();
        jsonData[0].name = "coderzero";
        jsonData[0].age = 48;
        jsonData[0].height = 172.5f;
        jsonData[0].man = true;
        jsonData[0].description = null;
        jsonData[0].tools = new string[3];
        jsonData[0].tools[0] = "Unity";
        jsonData[0].tools[1] = "Visual Studio";
        jsonData[0].tools[2] = "Photoshop";

        jsonData[1] = new JsonData();
        jsonData[1].name = "coderzero";
        jsonData[1].age = 48;
        jsonData[1].height = 172.5f;
        jsonData[1].man = true;
        jsonData[1].description = null;
        jsonData[1].tools = new string[2];
        jsonData[1].tools[0] = "3D Max";
        jsonData[1].tools[1] = "Photoshop";

        //인스턴스를 Json 포맷으로 직렬화
        string toJson0 = JsonUtility.ToJson(jsonData[0]);
        Debug.Log(toJson0);

        string toJson1 = JsonUtility.ToJson(jsonData[1]);
        Debug.Log(toJson1);

        //json 포맷에서 클래스나 구조체로 역직렬화
        JsonData fromJson = JsonUtility.FromJson<JsonData>(toJson0);
        Debug.Log(fromJson.name);

        //파일 저장
        File.WriteAllText(@"C:\Users\user\Desktop\JsonExample\JsonExample.json", toJson1);

        //파일 읽기
        string readJson = File.ReadAllText(@"C:\Users\user\Desktop\JsonExample\JsonExample.json");
        Debug.Log(readJson);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
