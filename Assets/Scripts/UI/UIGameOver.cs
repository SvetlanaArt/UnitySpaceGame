using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreController scoreControl;

    void Awake()
    {
        scoreControl = FindObjectOfType<ScoreController>();
    }

    void Start()
    {
        if (scoreControl != null)
        {
            scoreText.text = scoreControl.Score.ToString();
        }
    }

}
