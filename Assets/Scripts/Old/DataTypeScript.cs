using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{   //Transform, GameObject, string, Class : ref타입
    //Vector3, Quaternion : valueType
    // Start is called before the first frame update
    void Start()
    {
        //값 유형 변수
        Vector3 pos = transform.position;
        Debug.Log($"Value pos : {pos}");
        pos = new Vector3(0,2,0);
        Debug.Log($"Value pos : {pos}");
        

        //Ref유형 변수
        Transform tran = transform; //transform이 참조형식이기 때문에 transform을 직접 받아서 쓸 수 있는 것으로 해야 함.
        tran.position = new Vector3(0,2,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
