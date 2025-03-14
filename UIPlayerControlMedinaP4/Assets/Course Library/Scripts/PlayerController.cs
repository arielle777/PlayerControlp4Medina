using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    //private variables
    public Camera MainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    private float turnSpeed = 30.0f;
    private float speed = 20.0f;
    private float horizontalInput;
   private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player input 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        //turn the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            MainCamera.enabled = !MainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
