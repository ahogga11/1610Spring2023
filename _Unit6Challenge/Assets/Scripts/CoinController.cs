using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public int coin;
    // Start is called before the first frame update

    private void Start()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected!");
            coin = coin + 1;
            Col.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame

    private void Update()
    {
        
    }
}
