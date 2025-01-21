using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdates : MonoBehaviour
{
    void FixedUpdate()
    {
        //물리-> 0.02로 고정
        //만일 0.02를 초과하여 계산시 버그.
        Debug.Log($"FixedUpdate time: {Time.deltaTime}");
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 호출됨. 스크립트 활성화 되어야만 함
        Debug.Log($"Update time: {Time.deltaTime}");
    }

    void LateUpdate()
    {
        //Update하고 난 다음에 마지막 프레임에 돌아감.
        //모든 업데이트 함수가 호출되고 나서 마지막으로 호출되는 것.
    }


}
