using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody playerRb;
    private float speed = 500;
    private GameObject focalPoint;

  


   

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        // Add force to player in direction of the focal point (and camera)
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime);

        // Set powerup indicator position to beneath player
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb = GetComponent<Rigidbody>();
            playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime, ForceMode.Impulse);

        }

    }
}

    // If Player collides with powerup, activate powerup
   



    // Coroutine to count down powerup duration
   
   