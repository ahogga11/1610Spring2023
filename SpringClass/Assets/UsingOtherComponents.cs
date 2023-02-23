using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    
    
    private AnotherScript _anotherScript;
    private YetAnotherScript _yetAnotherScript;
    private BoxCollider _boxCol;
    
    
    void Awake ()
    {
        _anotherScript = GetComponent<AnotherScript>();
        _yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        _boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    
    void Start ()
    {
        _boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + _anotherScript.playerScore);
        Debug.Log("The player has died " + _yetAnotherScript.NumberOfPlayerDeaths+ " times");
    }
}

public partial class YetAnotherScript
{
    public object NumberOfPlayerDeaths;
}