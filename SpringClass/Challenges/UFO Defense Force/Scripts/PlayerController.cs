using System.Security.Cryptography;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;

    public GameObject lazerBolt;

    public GameManager gameManager;

    void Start()
    {   //                        GameObject                  Script Component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Referance GameManager script on GameManager object
    }

    // Update is called once per frame
    void Update()
    {
        // Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep player within set bounds 
        // Left Side Wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Right Side Wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // If space bar is pressed, fire lazerBolt
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // *Second condition gameManager.isGameOver prevents the player from shooting after isGameOver becomes true
        {
            // Create lazerBolt at the blaster transform position maintaining the object's rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }

    }

}
