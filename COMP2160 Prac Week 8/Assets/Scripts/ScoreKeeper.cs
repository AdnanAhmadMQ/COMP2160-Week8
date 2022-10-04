using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private int pointsPerCoin = 10;
    private int player1Score = 0;
    private int player2Score = 0;

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


    public void AddScoreP1()
    {
        player1Score += pointsPerCoin;
        UIManager.Instance.UpdateUI();
    }
    public void AddScoreP2()
    {
        player2Score += pointsPerCoin;
        UIManager.Instance.UpdateUI();
    }

    public int GetScoreP1()
    {
        return player1Score;
    }
    public int GetScoreP2()
    {
        return player2Score;
    }

}
