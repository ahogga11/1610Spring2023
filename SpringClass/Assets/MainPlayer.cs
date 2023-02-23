using UnityEngine;

public class MainPlayer : MonoBehaviour 
{
    public string myName;
    
    void Start () 
    {
        Debug.Log("I am alive and my name is " + myName);
    }
}