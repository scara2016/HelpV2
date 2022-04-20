using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionMovement : MonoBehaviour
{
    private float xMove;
    private float movementSpeed;

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

        //moves the object left or right depending on the input
        transform.Translate(new Vector2(movementSpeed * xMove * Time.deltaTime, 0));
    }
}
