using UnityEngine;
using System.Collections;

public class VariablesAndFunctions : MonoBehaviour
{
    private int myInt = 5;
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
