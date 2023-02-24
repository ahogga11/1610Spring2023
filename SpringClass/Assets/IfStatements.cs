using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float _coffeeTemperature = 85.0f;
    float _hotLimitTemperature = 70.0f;
    float _coldLimitTemperature = 40.0f;
    

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
        
        _coffeeTemperature -= Time.deltaTime * 5f;
    }
    
    
    void TemperatureTest ()
    {
        if(_coffeeTemperature > _hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }
        else if(_coffeeTemperature < _coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}