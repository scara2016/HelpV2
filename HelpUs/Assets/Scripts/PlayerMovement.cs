using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float xMove; //object movement input retrived from MovementManager
    
    private float movementSpeed; //object movement speed retrived from MovementManager

    private MovementManager movementManager;

    private float colCheck = 1;

    private void Awake()
    {
        movementManager = FindObjectOfType<MovementManager>();
    }

    void Start()
    {
        movementSpeed = movementManager.getMovementSpeed;
    }

    void Update()
    {
        xMove = movementManager.getXMove;
        if(xMove == 1)
        {

        }
        transform.Translate(new Vector2(movementSpeed * xMove * Time.deltaTime * colCheck, 0)); //moves the object left or right depending on the input
    }

    private void OnCollisionStay2D(Collision2D col) {
        
    }
}
