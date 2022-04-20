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
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = movementManager.getMovementSpeed;
    }

    // Update is called once per frame
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

        if(invertGravity == 1) {
            Debug.Log("Invert");
        }
    }
}
