using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityReverse : MonoBehaviour
{

    private MovementManager movementManager;
    public float convertDirection=9.8f;

    private void Awake() {
        movementManager = FindObjectOfType<MovementManager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeDirection()
    {
        convertDirection*=-1;
        Physics2D.gravity = new Vector2(0, convertDirection);
    }


}
