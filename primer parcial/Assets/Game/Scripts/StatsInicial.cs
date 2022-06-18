using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsInicial : MonoBehaviour
{
    public static StatsInicial Instance;
    [SerializeField] private Text _scoreWin;

    private int _scoreToWin;
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
        
         _scoreWin.text = "La Mision es hacer:  \n"+ GetScoreWin() + " puntos ";
    }

    public int GetScoreWin()
    {
        return _scoreToWin;
    }

    public void Init()
    {
        _scoreToWin = Random.Range(80, 200);
    }
}
