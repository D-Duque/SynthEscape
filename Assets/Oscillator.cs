using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent] //disallows multiple of the same component type on one object
public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(0f, 0f, 0f); 
    [SerializeField] float period = 2f; // time it takes to complete a full cycle

    float movementFactor; // 0 for not moved, 1 for fully moved

    Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // set movement factor
        if (period <= Mathf.Epsilon) { return; } // protect against period is zero. Epsilon is the smallest float possible.
        float cycles = Time.time / period; // grows continually from 0

        const float tau = Mathf.PI * 2; //about 6.28
        float rawSinWave = Mathf.Sin(cycles * tau); // goes from -1 to +1

        movementFactor = rawSinWave / 2f + 0.5f; 
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
