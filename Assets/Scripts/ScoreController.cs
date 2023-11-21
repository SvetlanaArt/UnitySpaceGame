using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public int Score { get; private set; }

    static ScoreController instance;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Game")
        {
            setStartScore();
        }
       CheckSingleton();
    }

    void CheckSingleton()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void addScore(int value)
    {  
        Score += value; 
    }

    public void setStartScore() 
    {
        if (instance != null)
        {
            instance.Score = 0;
        }
        else 
        { 
            Score = 0;
        }
    }
}
