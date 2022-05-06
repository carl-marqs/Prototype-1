using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 45;
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;

    private float horizontalInput;
    private float forwardInput;


    void Update()
    {
        // Axis setup
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // Moves the car forward based on vertical input
        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        // Rotates the car based on horizontal input
        if (forwardInput != 0) // do not rotate if not moving
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Camera switcher
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}
