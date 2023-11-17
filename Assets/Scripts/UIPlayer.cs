using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDisplay : MonoBehaviour
{
    [Header("Life")]
    [SerializeField] Slider lifeSlider;
    [SerializeField] LifeCounter playerLife;

    [Header("Score")]
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreController scoreControl;

    void Awake()
    {
        scoreControl = FindObjectOfType<ScoreController>();
    }

    void Start()
    {
        lifeSlider.maxValue = playerLife.getStartLife();
    }

    void Update()
    {
        scoreText.text = scoreControl.Score.ToString("000000000");
        lifeSlider.value = playerLife.Life;
    }
}
