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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Happened");
        if (collision.gameObject.tag == "Player")
        {
            if (!colorActivated)
            {
                colorActivated = true;
                buttonOn = true;
                colorChange();
            }
            else
            {
                colorActivated = false;
                buttonOn = false;
                colorChange();
            }
        }
    }

    private void colorChange()
    {
        if (colorActivated)
        {
            spriteRenderer.color = Color.blue;
        }
        else
        {
            spriteRenderer.color = Color.cyan;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
