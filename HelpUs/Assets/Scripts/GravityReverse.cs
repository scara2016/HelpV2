using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityReverse : MonoBehaviour
{

    private MovementManager movementManager;
    
    public float convertDirection=2f;
    private Rigidbody2D rb;

    private float invertGravity;
    private float timer=0.2f;

    private void Awake()
    {
        movementManager = FindObjectOfType<MovementManager>();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ChangeDirection();
    }

    void Update()
    {
        invertGravity = movementManager.getInvertGravity;
        if(invertGravity==1)
        {
            if(timer<=0)
            {
            ChangeDirection();
            timer=0.2f;
            }
        }
        timer-=Time.deltaTime;
    }

    public void ChangeDirection()
    {
        convertDirection*=-1;
        rb.gravityScale =convertDirection ;
    }
}
