using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class StatsPlayer : MonoBehaviour
{
    public static StatsPlayer Instance;
    [SerializeField] private Text _life;
    private int _lifePlayer;

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
        if (GetLife() > 0)
        {
            _life.text = "Vida: " + GetLife();
        }
        else
        {
            GameLogic.Instance.Lose();
        }
    }

    public int GetLife()
    {
        return _lifePlayer;
    }

    public void RestLife(int amount)
    {
        _lifePlayer -= amount;
    }

    public void Init()
    {
        _lifePlayer = Random.Range(30,100);
    }
}
