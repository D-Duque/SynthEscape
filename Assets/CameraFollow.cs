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

        int buildIndex = currentScene.buildIndex;

        switch (buildIndex)
        {
            case 3:
                FollowXAndYAxis();
                break;
            case 4:
                FollowXAndYAxis();
                    break;
            default:
                FollowXAxis();
                    break;
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
