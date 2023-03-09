using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class NewBehaviourScript : ScriptableObject{

public new string name;
public string description;

public Sprite artwork;

public int manaCost;
public int attack;
public int health;

}
