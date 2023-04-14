using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        // Move GameObject forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
