using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public Transform other;

    void Update()
    {
        if (other)
        {
            Transform transform1;
            Vector3 forward = (transform1 = transform).TransformDirection(Vector3.forward);
            Vector3 toOther = other.position - transform1.position;

            if (Vector3.Dot(forward, toOther) < 0)
            {
                print("The other transform is behind me!");
            }
        }
    }
}