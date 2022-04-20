using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    private PlayerControls playerControls;
    [SerializeField] private float movementSpeed;
    public float getMovementSpeed {
        get {return movementSpeed;}
    }

    private float xMove;
    public float getXMove {
        get {return xMove;}
    }
    private float invertGravity;
    public float getInvertGravity {
        get {return invertGravity;}
    }

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
        xMove = playerControls.Movement.XMovement.ReadValue<float>();
        invertGravity = playerControls.Movement.InvertGravity.ReadValue<float>();
        if(invertGravity == 1) {
            
        }
    }

    

    
}
