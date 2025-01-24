using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard, downgfx, upgfx, heldgfx;
    public TMP_Text boolDisplay1, boolDisplay2, boolDisplay3;
    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButtonDown("Fire1");
        bool held = Input.GetButton("Fire1");
        bool up = Input.GetButtonUp("Fire1");


        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if(held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite=standard;
        }

        boolDisplay1.text = $"GetBtnDown: {down}";
        boolDisplay2.text = $"GetBtn: {held}";
        boolDisplay3.text = $"GetBtnUp: {up}";
    }
}
