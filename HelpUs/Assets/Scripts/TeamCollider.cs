using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamCollider : MonoBehaviour
{

    private Transform target; 
    private int nextScene;

     private string SceneFormat= "Level{0}";
    private string SceneNumber;


    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player1");
        if(player!=null)
        {
            target=player.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        GameObject other = collider.gameObject;
        Transform seeIfTeam=collider.transform;

        if(seeIfTeam==target)
        {
            nextScene=GameManager.Instance.GetNextScene();
            SceneNumber= string.Format(SceneFormat, nextScene);
            GameManager.Instance.NextScene(SceneNumber);
        }
    }
}
