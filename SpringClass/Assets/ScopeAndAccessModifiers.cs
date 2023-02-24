using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5;
    
    
    private int beta = 0;
    private int gamma = 5;
    
    
    private AnotherClass _myOtherClass;
    
    
    void Start ()
    {
        alpha = 29;
        
        _myOtherClass = new AnotherClass();
        _myOtherClass.FruitMachine(alpha, _myOtherClass.Apples);
    }
    
    
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    
    
    void Update ()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
