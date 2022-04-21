using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("No UIManager in the scene");
            }
            return instance;
        }
    }

    private string SceneFormat= "Level {0}";
    public TMP_Text levelText;
    private float timer=3f;
    public GameObject PanelLevel;
    public GameObject Canvas;

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
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(Canvas);
        LevelDisplay(1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<=0)
        {
            PanelLevel.SetActive(false);
        }
        if(timer>0){
        timer-=Time.deltaTime;
        }
    }

    public void LevelDisplay(int currentlevel){
        levelText.text = string.Format(SceneFormat, currentlevel);   
        PanelLevel.SetActive(true);  
        timer=3f; 
    }
}
