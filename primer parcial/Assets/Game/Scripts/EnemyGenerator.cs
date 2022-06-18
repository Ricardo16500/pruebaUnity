using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyGenerator : MonoBehaviour
{
    public static EnemyGenerator Instance;
    [SerializeField] private GameObject _enemy1;
    [SerializeField] private GameObject _enemy2;
    [SerializeField] private GameObject _enemy3;
    [SerializeField] private float _timeBenemy;
    private float _timeBenemyaux;
    private int _random;
    private int maximo;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        maximo = 20;
        _timeBenemyaux = _timeBenemy;
    }

    // Update is called once per frame
    void Update()
    {
        if (maximo > 0)
        {
            _timeBenemy -= Time.deltaTime;
        //print(_timeBenemy);
        if (_timeBenemy <= 0)
        {
            _random = Random.Range(1, 4);
            if (_random == 1)
            {
                float randomE1X = Random.Range(-1.77f,1.83f);
                float randomE1Y = Random.Range(2.61f,-0.06f);
                Vector2 position = new Vector2(randomE1X, randomE1Y);
                Instantiate(_enemy1, position, Quaternion.identity);
            }
            else
            {
                if (_random == 2)
                {
                    float randomE2X = Random.Range(-1.87f,2.07f);
                    float randomE2Y = Random.Range(-3.48f, 3.03f);
                    Vector2 position = new Vector2(randomE2X, randomE2Y);
                    Instantiate(_enemy2, position, Quaternion.identity);
                }
                else
                {
                    float randomE3X = Random.Range(-1.95f,1.68f);
                    float randomE3Y = Random.Range(3.31f, -2.96f);
                    Vector2 position = new Vector2(randomE3X, randomE3Y);
                    Instantiate(_enemy3, position, Quaternion.identity);
                }
            }

            _timeBenemy = _timeBenemyaux;
            maximo--;
        }
        }
    }

    
}
