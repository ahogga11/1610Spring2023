using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnCoinScript : MonoBehaviour
{
    public GameObject coinPrefab;

    public int coin;

    public TextMeshProUGUI textCoin;

    public float timeRemaining = 2f;


    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if (timeRemaining < 0)
        {
            timeRemaining = Random.Range(1,3);
            spawn_coin();
        }
    }
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected!");
            coin = coin + 1;
            textCoin.text = coin.ToString();
            Col.gameObject.SetActive(false);
        }
        void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other);
            Debug.Log("Coin Collected!");
        }
    }

    
    }

    public void spawn_coin()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        Instantiate(coinPrefab, randomPosition, Quaternion.identity);
    }
}
