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

    // Start is called before the first frame update
    void Start()
    {
        moveActivated = activatorButton.ButtonOn;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime / timeToReachTarget;
        moveActivated = activatorButton.ButtonOn;
        
        if (moveActivated)
        {
            this.transform.transform.position = Vector3.Lerp(StartPoint.position, EndPoint.position, t);
        }

        // if(!moveActivated)
        // {
        //     this.transform.transform.position = Vector3.Lerp(EndPoint.position, StartPoint.position, t);
        // }
    }

}
