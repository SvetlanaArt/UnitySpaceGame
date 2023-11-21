using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    [SerializeField] int startLife = 100;
    [SerializeField] bool isScoreObject = false;

    private ScoreController scoreControl;
 
    public int Life { get; private set; }

    public int getStartLife()
    {
        return startLife;
    }

    public void resetLife()
    {
        Life = startLife;
    }

    private void Awake()
    {
        resetLife();
        scoreControl = FindObjectOfType<ScoreController>();
    }

    void OnTriggerEnter2D(Collider2D spaceBody)
    {
        DamageMaker damageMaker = spaceBody.GetComponent<DamageMaker>();
        if (damageMaker != null)
        {
            TakeDamage(damageMaker.MakedDamage());
        }
    }

    void TakeDamage(int damage)
    {
        Life -= damage;
    }

    private void Update()
    {
        CheckLife();
    }

    void CheckLife()
    {
        if (Life <= 0)
        {
            if (scoreControl != null && isScoreObject)
            {
                scoreControl.addScore(startLife);
            }
            Destroy(gameObject);
        }
    }

}
