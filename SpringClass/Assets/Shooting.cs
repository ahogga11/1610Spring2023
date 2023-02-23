using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    
    
    private Inventory _inventory;
    
    
    void Awake ()
    {
        _inventory = GetComponent<Inventory>();
    }
    
    
    void Update ()
    {
        Shoot();
    }
    
    
    void Shoot ()
    {
        if(Input.GetButtonDown("Fire1") && _inventory.MyStuff.Bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation);
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            _inventory.MyStuff.Bullets--;
        }
    }
}