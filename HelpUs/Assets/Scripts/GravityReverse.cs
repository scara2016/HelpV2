using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityReverse : MonoBehaviour
{

    private MovementManager movementManager;
    public float convertDirection=2f;
    private Rigidbody2D rb;
    private float invertGravity;
    private void Awake() {
        movementManager = FindObjectOfType<MovementManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        invertGravity = movementManager.getInvertGravity;
        if(invertGravity==1)
        {
        ChangeDirection();
        }
    }


    public void ChangeDirection()
    {
        convertDirection*=-1;
        rb.gravityScale =convertDirection ;
       
    }


}
