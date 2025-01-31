using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AxisExample : MonoBehaviour
{
    public float range_h;
    public float range_v;
    public TextMeshPro text_h;
    public TextMeshPro text_v;
    // Start is called before the first frame update
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");//GetAxis(연속값)
        float xPos = h * range_h;

        float v = Input.GetAxis("Vertical");
        float yPos = v *  range_v;

        transform.position = new Vector3(xPos, 2f, yPos);
        text_h.text = $"float_h : {h:F2}";
        text_v.text = $"float_v : {v:F2}";
    }
}
