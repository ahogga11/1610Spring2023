using UnityEngine;

public class MouseClick : MonoBehaviour
{

    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown ()
    {
        _rb.AddForce(-transform.forward * 500f);
        _rb.useGravity = true;
    }
}
