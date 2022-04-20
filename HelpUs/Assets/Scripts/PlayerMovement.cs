using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float xMove; //object movement input retrived from MovementManager
    
    private float movementSpeed; //object movement speed retrived from MovementManager

    private MovementManager movementManager;

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
        transform.Translate(new Vector2(movementSpeed * xMove * Time.deltaTime, 0)); //moves the object left or right depending on the input
    }
}
