using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private int pointsPerCoin = 10;
    private int currScore = 0;

    static private ScoreKeeper instance;
    static public ScoreKeeper Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            Debug.Log("there is no scorekeeper");
        }

        instance = this;
    }


    public void AddScore()
    {
        currScore += pointsPerCoin;
        UIManager.Instance.UpdateUI();
    }

    public int GetScore()
    {
        return currScore;
    }


    // Update is called once per frame
    void Update()
    {
    }
}
