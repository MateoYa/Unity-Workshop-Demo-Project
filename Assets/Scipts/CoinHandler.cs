using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinHandler : MonoBehaviour
{
    public int Coins = 0;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Coins: " + Coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin(int value = 1)
    {
        Coins++;
        score.text = "Coins: " + Coins.ToString();
    }
}
