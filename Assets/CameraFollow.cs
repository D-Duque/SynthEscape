using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // sets camera follow rules by level
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Level 3")
        {
            FollowXAxis();
        }
        else if (sceneName == "Level 4")
        {
            FollowXAndYAxis();
        }
        else if (sceneName == "Level 5")
        {
            FollowXAndYAxis();
        }
    }

    private void FollowXAxis() // camera follows player along the x axis
    {
        transform.position = new Vector3(player.position.x + offset.x, offset.y, offset.z);
    }

    private void FollowXAndYAxis() // camera follows player along the y axis
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
    }
}
