using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    // current way and direction for enemy movement
    [SerializeField] bool repeateEnemySets;
    [SerializeField] List<EnemySetObject> enemySets;
    
    EnemySetObject currentSet;

    void Start()
    {
        StartCoroutine( Generator());
    }

    public EnemySetObject GetCurrentSet()
    {
        return currentSet;
    }

    // Generate enemies
    IEnumerator Generator()
    {
        while (repeateEnemySets)
        {

            foreach (EnemySetObject set in enemySets)
            {
                for (int i = 0; i < set.GetEnemiesCount(); i++)
                {
                    currentSet = set;
                    Instantiate(set.GetEnemyPrefab(i),
                                set.GetStartElement().position,
                                Quaternion.Euler(0, 0, 180),
                                transform);
                    yield return new WaitForSeconds(set.GetRandomTimeBetweenEnemy(false));
                }
                yield return new WaitForSeconds(set.GetRandomTimeBetweenEnemy(true));
            }
        }
    }
}

