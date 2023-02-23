using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    private int MyInt = 5;
    void Start()
    {
        MyInt = MultiplyByTwo(MyInt);
        Debug.Log(MyInt);
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}