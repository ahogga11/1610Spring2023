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

    public float timeRemaining = 2f;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if (timeRemaining < 0)
        {
            timeRemaining = Random.Range(1, 3);
            spawn_coin();
        }
        void spawn_coin()
        {
            Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            Instantiate(coinPrefab, randomPosition, Quaternion.identity);
        }



        void OnTriggerEnter(Collider Col)
        {
            if (Col.gameObject.tag == "Coin")
            {
                Debug.Log("Coin Collected!");
                coin = coin + 1;
                textCoin.text = coin.ToString();
                Col.gameObject.SetActive(false);
                Destroy(Col);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Vector3 randomPosition = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                Instantiate(coinPrefab, randomPosition, Quaternion.identity);
            }
        }
        // Update is called once per frame
    }
}
