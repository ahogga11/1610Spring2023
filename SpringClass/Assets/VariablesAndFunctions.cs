using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    private int _myInt = 5;
    void Start()
    {
        _myInt = MultiplyByTwo(_myInt);
        Debug.Log(_myInt);
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
