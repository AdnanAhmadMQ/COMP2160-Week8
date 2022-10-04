using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.GetComponent<PlayerMove>())
        {
            Debug.Log("Coin hit");
            ScoreKeeper.Instance.AddScore();
            Destroy(this.gameObject);
        }
    }
}
