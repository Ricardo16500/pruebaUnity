using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public static Stats Instance;
    //[SerializeField] private Text _scoreText;
    //[SerializeField] private Text _life;
    [SerializeField] private Text _time;
    private float _timeToFinish;

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
        if (_timeToFinish > 0)
        {
            //RestTime(Time.deltaTime);
            _timeToFinish -= Time.deltaTime;
            _time.text = "Tiempo: "+ Mathf.Round(_timeToFinish);
        }
        else
        {
            GameLogic.Instance.Lose();
        }
        
    }

    public void Init()
    {
       _timeToFinish = Random.Range(20,60);
    }
    public float GetTime()
    {
        return _timeToFinish;
    }

    public void RestTime(float time)
    {
        _timeToFinish -= time;
    }
    
}
