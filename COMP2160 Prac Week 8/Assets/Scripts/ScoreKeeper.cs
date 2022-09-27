using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    static private ScoreKeeper instance;

    static public ScoreKeeper Instance
    {
        get
        {
            return instance;
        }
    }

    void OnAwake()
    {
        //if(instance == null)
        //{
        //    Debug.Log("there is no scorekeeper");
        //}
        instance = this;
    }

    private int score = 0;
    [SerializeField] private int points = 10;

    public void AddScore()
    {
        score += points;
    }

    public int whatScore()
    {
        return score;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
