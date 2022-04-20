using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float xMove;
    private float invertGravity;
    private float movementSpeed;

    private MovementManager movementManager;

    private void Awake() {
        movementManager = FindObjectOfType<MovementManager>();
    }

    void Start()
    {
        movementSpeed = movementManager.getMovementSpeed;
    }

    void Update()
    {
        xMove = movementManager.getXMove;
        invertGravity = movementManager.getInvertGravity;

        if(xMove == -1) {
            transform.Translate(movementSpeed * Vector2.left * Time.deltaTime);
        }

        if(xMove == 1) {
            transform.Translate(movementSpeed * Vector2.right * Time.deltaTime);
        }

    }
}
