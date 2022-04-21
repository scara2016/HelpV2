using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehaviour : MonoBehaviour
{
    private string SceneFormat = "Level{0}";
    private string SceneNumber;

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            SceneNumber = string.Format(SceneFormat, GameManager.Instance.GetCurrentScene());
            GameManager.Instance.NextScene(SceneNumber);
        }
    }
}
