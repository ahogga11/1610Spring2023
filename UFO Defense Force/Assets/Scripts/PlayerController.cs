using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;

    public GameObject lazerBolt;


    // Update is called once per frame
    void Update()
    {
        // Set horizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep player within bounds 
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
        // Create lazerBolt at the blaster transform position maintaining the object's rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }
    // Delete any object with a trigger that hits the player

        private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}