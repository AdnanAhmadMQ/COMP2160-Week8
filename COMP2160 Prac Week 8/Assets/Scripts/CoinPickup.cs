using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.GetComponent<PlayerMove>())
        {
            if (c.gameObject.tag == "Player1")
            {
                ScoreKeeper.Instance.AddScoreP1();
                Destroy(this.gameObject);
            }
            else
            {
                ScoreKeeper.Instance.AddScoreP2();
                Destroy(this.gameObject);
            }
            
        }

    }
}
