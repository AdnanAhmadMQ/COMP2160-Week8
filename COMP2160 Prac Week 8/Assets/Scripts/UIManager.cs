using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject scoreText;
    string scoreBaseText = "Score = ";

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

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateUI()
    {
        scoreText.GetComponent<Text>().text = (scoreBaseText + ScoreKeeper.Instance.GetScore());
    }
}
