using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject scoreText;
    //[SerializeField] GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        //ScoreKeeper.Instance.AddScore();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log("score =" + ScoreKeeper.Instance.whatScore());
    }
}
