using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreStats : MonoBehaviour
{
    public static ScoreStats Instance;
    [SerializeField] private Text _scoreText;

    private int _score;
    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Init();
        
    }

    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score: "+GetScore() +" - " +StatsInicial.Instance.GetScoreWin() ;
        if (GetScore() >= StatsInicial.Instance.GetScoreWin())
        {
            GameLogic.Instance.Win();
        }
    }
    public int GetScore()
    {
        return _score;
    }

    public void AddScore(int amount)
    {
        _score += amount;
    }

    public void Init()
    {
        _score = 0;
    }
    
}
