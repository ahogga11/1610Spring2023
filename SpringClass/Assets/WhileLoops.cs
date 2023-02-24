using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int _cupsInTheSink = 4;
    
    
    void Start ()
    {
        while(_cupsInTheSink > 0)
        {
            Debug.Log ("I've washed a cup!");
            _cupsInTheSink--;
        }
    }
}
