using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoorMovement : MonoBehaviour
{
    private bool moveActivated;
    public Buttons activatorButton;
    public Transform StartPoint;
    public Transform EndPoint;
    public float timeToReachTarget = 2;
    private float t;

    void Start()
    {
        moveActivated = activatorButton.ButtonOn;
    }

    void Update()
    {
        t += Time.deltaTime / timeToReachTarget;
        moveActivated = activatorButton.ButtonOn;
        
        if (moveActivated)
        {
            this.transform.transform.position = Vector3.Lerp(StartPoint.position, EndPoint.position, t);
        }
    }

}
