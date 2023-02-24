using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    private Light _myLight;
    
    
    void Start ()
    {
        _myLight = GetComponent<Light>();
    }
    
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            _myLight.enabled = !_myLight.enabled;
        }
    }
}