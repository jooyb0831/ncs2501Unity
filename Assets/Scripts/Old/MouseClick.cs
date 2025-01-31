using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        rigid.AddForce(transform.up * 500f);
        rigid.useGravity= true;
    }
}
