using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera MainCamera;
    public Camera DriveCamera;
    public KeyCode space;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // move fwd
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(space))
        {
            MainCamera.enabled = !MainCamera.enabled;
            DriveCamera.enabled = !DriveCamera.enabled;
        }
    }
}
