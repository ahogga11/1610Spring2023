using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int _numEnemies = 3;
    
    
    void Start ()
    {
        for(int i = 0; i < _numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}