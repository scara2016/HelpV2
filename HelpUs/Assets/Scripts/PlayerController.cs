using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControls;

    [SerializeField] private Transform playerMain;
    [SerializeField] private Transform playerReflection;
    [SerializeField] private float movementSpeed;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Start()
    {

    }

    private void Update() {
        float xMove = playerControls.Movement.LeftandRight.ReadValue<float>();
        float invertGravity = playerControls.Movement.InvertGravity.ReadValue<float>();
        if(invertGravity == 1) {
            
        }
    }
}
