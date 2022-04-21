using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    private static CanvasManager instance;
    public static CanvasManager Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("No Canvas in the scene");
            }
            return instance;
        }
    }

        void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
