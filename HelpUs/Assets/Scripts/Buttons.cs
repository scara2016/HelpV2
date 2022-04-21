using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    private bool colorActivated = false;
    private bool buttonOn = false;
    SpriteRenderer spriteRenderer;

    public bool ButtonOn
    {
        get
        {
            return buttonOn;
        }
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Happened");
        if (collision.gameObject.tag == "Player" && !colorActivated)
        {
            colorActivated = true;
            buttonOn = true;
            colorChange();
        }
    }

    private void colorChange()
    {
        spriteRenderer.color = Color.blue;
    }
}
