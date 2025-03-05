using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Form1 : MonoBehaviour
{
    Button button;
    GameObject obj;
    int x ;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>(); 
        button.onClick.AddListener(button1_Click);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void button1_Click()
    {
        Debug.Log("버튼 1클릭");
    }
}
