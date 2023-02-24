using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int Bullets;
        public int Grenades;
        public int Rockets;
        public float Fuel;
        
        public Stuff(int bul, int gre, int roc)
        {
            Bullets = bul;
            Grenades = gre;
            Rockets = roc;
        }
        
        public Stuff(int bul, float fu)
        {
            Bullets = bul;
            Fuel = fu;
        }
        
        // Constructor
        public Stuff ()
        {
            Bullets = 1;
            Grenades = 1;
            Rockets = 1;
        }
    }
    

    // Creating an Instance (an Object) of the Stuff class
    public Stuff MyStuff = new Stuff(50, 5, 5);
    
    public Stuff MyOtherStuff = new Stuff(50, 1.5f);
    
    void Start()
    {
        Debug.Log(MyStuff.Bullets); 
    }
}
