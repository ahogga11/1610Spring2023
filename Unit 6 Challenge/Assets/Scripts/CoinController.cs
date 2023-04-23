using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    public GameObject coinPrefab;

    public int coin;

    public TextMeshProUGUI textCoin;
    // Start is called before the first frame update

    private void Start()
    {
       
    }

    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected!");
            coin = coin + 1;
            textCoin.text = coin.ToString();
            Col.gameObject.SetActive(false);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            Instantiate(coinPrefab, randomPosition, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
