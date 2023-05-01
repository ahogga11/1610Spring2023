using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; // Store reference to score manager

    public int scoreToGive;
    
    void Start () 
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager gameobject and reference ScorManager script component
        
    }
        void OnTriggerEnter(Collider other) // Once the Trigger has been entered record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the Score
        Destroy(gameObject);// Destroy this gameObject
        Destroy(other.gameObject); // Destroy the other gameObject it hits
    }

}

