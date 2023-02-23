using UnityEngine;

public class AnotherClass
{
    public int Apples;
    public int Bananas;
    
    
    private int _stapler;
    private int _sellotape;
    
    
    public void FruitMachine (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }
    
    
    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
