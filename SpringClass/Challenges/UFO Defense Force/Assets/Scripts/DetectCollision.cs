using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        // Destroy this gameObject
        Destroy(gameObject);
        // Destroy the other gameObject it hits
        Destroy(other.gameObject);
    }
}
