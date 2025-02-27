using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ButtonEvent
{
    public event EventHandler Click; // 이벤트 정의

    public void MouseButtonDown()
    {
        if(this.Click != null) // Click이 null이 아닐 경우
        {
            Click(this, EventArgs.Empty); // 이벤트 핸들러들을 호출
        }
    }
}
public class EventExample : MonoBehaviour
{
    //이벤트에서는 = 사용 불가(델리게이트에서만 가능)
    //하나의 이벤트에는 여러개의 이벤트 넣을 수 있음.
    //이벤트 발생하면 추가된 이벤트 핸들러 모두 순차적으로 호출.
    // Start is called before the first frame update
    void Start()
    {
        ButtonEvent buttonEvent = new ButtonEvent();
        buttonEvent.Click += new EventHandler(ButtonClick); // 이벤트 연결

        buttonEvent.MouseButtonDown();

    }

    void ButtonClick(object sender, EventArgs e) // 실행 매서드 : 이벤트 발생
    {
        Debug.Log("버튼 클릭");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
