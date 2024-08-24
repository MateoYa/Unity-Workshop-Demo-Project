using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public CoinHandler coinsHandle;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        coinsHandle.AddCoin();
        Destroy(this.gameObject);
    }
}
