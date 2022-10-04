using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject scoreTextP1;
    [SerializeField] GameObject scoreTextP2;
    string scoreBaseTextP1 = "Player 1 Score = ";
    string scoreBaseTextP2 = "Player 2 Score = ";

    static private UIManager instance;
    static public UIManager Instance
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
            Debug.Log("there is no UI Manager");
        }

        instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        scoreTextP1.GetComponent<Text>().text = (scoreBaseTextP1 + ScoreKeeper.Instance.GetScoreP1());
        scoreTextP2.GetComponent<Text>().text = (scoreBaseTextP2 + ScoreKeeper.Instance.GetScoreP2());
    }
}
