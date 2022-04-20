using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = new PlayerMovement();
    }

    private void OnEnable()
    {
        playerMovement.Enable();
    }

    private void OnDisable()
    {
        playerMovement.Disable();
    }

    void Start()
    {

    }

    private void Update() {
        float xMove = playerMovement.Movement.LeftandRight.ReadValue<float>();

        float invertGravity = playerMovement.Movement.InvertGravity.ReadValue<float>();
        if(playerMovement.Movement.InvertGravity.ReadValue<float>() == 1)
        if(playerMovement.Movement.InvertGravity.triggered)
        {
            Debug.Log("Invert");
        }
    }
}
