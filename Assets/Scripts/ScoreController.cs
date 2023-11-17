using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int Score { get; private set; }

    private void Awake()
    {
        setStartScore();
    }

    public void addScore(int value)
    {  
        Score += value; 
    }

    public void setStartScore() 
    { 
        Score = 0; 
    }
}
