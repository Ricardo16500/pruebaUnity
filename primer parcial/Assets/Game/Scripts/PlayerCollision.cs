using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerCollision : MonoBehaviour
{
    private int _enemyLife;
    private int _compare;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        _enemyLife = Random.Range(30, 60);
        Debug.Log("vida enemigos "+_enemyLife);
        Debug.Log("vida player " + StatsPlayer.Instance.GetLife());
        if (other.CompareTag("Enemy1"))
        {
           // _compare = GetComponent<StatsPlayer>().GetLife();
            if (StatsPlayer.Instance.GetLife() >= _enemyLife)
            {
                Destroy(other.gameObject);
                /*StatsPlayer.Instance.RestLife(1);
                ScoreStats.Instance.AddScore(10);*/
                StatsPlayer.Instance.RestLife(1);
                ScoreStats.Instance.AddScore(10);
            }
            else
            {
                
                GameLogic.Instance.Lose();
                Destroy(other.gameObject);
            }
        }
        else
        {
            if (other.CompareTag("Enemy2"))
            {
                //_compare = GetComponent<StatsPlayer>().GetLife();
                if (StatsPlayer.Instance.GetLife() >= _enemyLife)
                {
                    Destroy(other.gameObject);
                    /*StatsPlayer.Instance.RestLife(1);
                    ScoreStats.Instance.AddScore(20);*/
                    StatsPlayer.Instance.RestLife(1);
                    ScoreStats.Instance.AddScore(20);
                }
                else
                {
                    
                    GameLogic.Instance.Lose();
                    Destroy(other.gameObject);
                }
            }
            else
            {
                if (other.CompareTag("Enemy3"))
                {
                    //_compare = GetComponent<StatsPlayer>().GetLife();
                    if (StatsPlayer.Instance.GetLife()>= _enemyLife)
                    {
                        Destroy(other.gameObject);
                        /*StatsPlayer.Instance.RestLife(1);
                        ScoreStats.Instance.AddScore(50);*/
                        StatsPlayer.Instance.RestLife(1);
                        ScoreStats.Instance.AddScore(50);
                    }
                    else
                    {
                        
                        GameLogic.Instance.Lose();
                        Destroy(other.gameObject);
                    }
                }
            }
        }
    }
}
