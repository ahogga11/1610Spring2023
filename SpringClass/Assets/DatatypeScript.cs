using UnityEngine;

public class DatatypeScript : MonoBehaviour 
{
    void Start () 
    {
        //Value type variable
        var transform1 = transform;
        Vector3 pos = transform1.position;
        pos = new Vector3(0, 2, 0);
        
        //Reference type variable
        Transform tran = transform1;
        tran.position = new Vector3(0, 2, 0);
    }
}
