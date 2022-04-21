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

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        instance = this;
    }

    //loads the next scene
    public void NextScene(string level)
    {
        SceneManager.LoadScene(level);
    }

    //gets the number of the next scene
    public int GetNextScene()
    {
        currentScene++;
        return currentScene;
    }

    //gets the current scene
    public int GetCurrentScene()
    {
        return currentScene;
    }
}
