using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public static GameLogic Instance;
    public enum GameState
    {
        Menu,
        Mision,
        Playing, 
        Win,
        Lose
    }

    private GameState _gameState;
    [SerializeField] private GameObject _uiMenu;
    [SerializeField] private GameObject _uiMision;
    [SerializeField] private GameObject _uiMain;
    [SerializeField] private GameObject _uiWin;
    [SerializeField] private GameObject _uiLose;

    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _enemygenerator;
    [SerializeField] private GameObject stats;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameState = GameState.Menu;
        Instance = this;
        _player.GetComponent<PlayerMovement>().enabled = false;
        _enemygenerator.GetComponent<EnemyGenerator>().enabled = false;
        stats.GetComponent<ScoreStats>().enabled = false;
        stats.GetComponent<StatsPlayer>().enabled = false;
        _uiLose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameState == GameState.Menu)
        {
            _uiMision.SetActive(false);
            _uiMenu.SetActive(true);
            _uiWin.SetActive(false);
            _uiLose.SetActive(false);
            _uiMain.SetActive(false);
            
        }
        else if (_gameState == GameState.Playing)
        {
            _player.GetComponent<PlayerMovement>().enabled = true;
            _enemygenerator.GetComponent<EnemyGenerator>().enabled = true;
            stats.GetComponent<ScoreStats>().enabled = true;
            stats.GetComponent<StatsPlayer>().enabled = true;
        } else if (_gameState == GameState.Lose)
        {
            _player.GetComponent<PlayerMovement>().enabled = false;
            _enemygenerator.GetComponent<EnemyGenerator>().enabled = false;
            stats.GetComponent<ScoreStats>().enabled = false;
            stats.GetComponent<StatsPlayer>().enabled = false;
        }else if (_gameState == GameState.Win)
        {
            _player.GetComponent<PlayerMovement>().enabled = false;
            _enemygenerator.GetComponent<EnemyGenerator>().enabled = false;
            stats.GetComponent<ScoreStats>().enabled = false;
            stats.GetComponent<StatsPlayer>().enabled = false;
        }
        else if (_gameState == GameState.Menu)
        {
            _player.GetComponent<PlayerMovement>().enabled = false;
            _enemygenerator.GetComponent<EnemyGenerator>().enabled = false;
            stats.GetComponent<ScoreStats>().enabled = false;
            stats.GetComponent<StatsPlayer>().enabled = false;
        }else if (_gameState == GameState.Mision)
        {
            _player.GetComponent<PlayerMovement>().enabled = false;
            _enemygenerator.GetComponent<EnemyGenerator>().enabled = false;
            stats.GetComponent<ScoreStats>().enabled = false;
            stats.GetComponent<StatsPlayer>().enabled = false;
        }
    }

    public void SeeMision()
    {
        StatsInicial.Instance.Init();
        _gameState = GameState.Mision;
        _uiMision.SetActive(true);
        _uiMenu.SetActive(false);
        _uiWin.SetActive(false);
        _uiLose.SetActive(false);
        _uiMain.SetActive(false);
    }

    public void StartGame()
    {
        Stats.Instance.Init();
        //StatsInicial.Instance.Init();
        ScoreStats.Instance.Init();
        StatsPlayer.Instance.Init();
       
        _gameState = GameState.Playing;
        _uiMision.SetActive(false);
        _uiMenu.SetActive(false);
        _uiWin.SetActive(false);
        _uiLose.SetActive(false);
        _uiMain.SetActive(true);
    }
    public void Exit()
    {
        Debug.Log("Se salio del juego");
        Application.Quit();
    }

    public void Win()
    {
        _gameState = GameState.Win;
        _uiMision.SetActive(false);
        _uiMenu.SetActive(false);
        _uiWin.SetActive(true);
        _uiLose.SetActive(false);
        _uiMain.SetActive(false);
    }

    public void Lose()
    {
        _gameState = GameState.Lose;
        _uiMision.SetActive(false);
        _uiMenu.SetActive(false);
        _uiWin.SetActive(false);
        _uiLose.SetActive(true);
        _uiMain.SetActive(false);
    }

    public void RestartMenu()
    {
        _gameState = GameState.Menu;
        _uiMision.SetActive(false);
        _uiMenu.SetActive(true);
        _uiWin.SetActive(false);
        _uiLose.SetActive(false);
        _uiMain.SetActive(false);
    }
    
}
