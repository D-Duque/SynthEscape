using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource thrusterSound;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        thrusterSound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) // can thrust while rotating
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!thrusterSound.isPlaying) // so the clip doesn't layer and cause sound artifacts
            {
                thrusterSound.Play();
            }
        }
        else
        {
            thrusterSound.Stop();
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
        }
    }
}
