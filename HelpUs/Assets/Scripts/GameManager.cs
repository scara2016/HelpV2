using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("No GameManager in the scene");
            }
            return instance;
        }
    }

    private int currentScene;


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
        currentScene=1;
    }


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NextScene(string level)
    {
        SceneManager.LoadScene(level);
        UIManager.Instance.LevelDisplay(currentScene);
    }

    public int GetNextScene()
    {
        currentScene++;
        return currentScene;
    }
}
