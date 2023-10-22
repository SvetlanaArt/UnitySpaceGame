using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Set", fileName = "New Enemy Set")]
public class EnemySetObject : ScriptableObject
{
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] Transform wayPrefab;
    [SerializeField] float speed = 5f;
    [SerializeField] float timeBetweenEnemyGenerate = 0.8f;
    [SerializeField] float timeVariance = 0f;
    [SerializeField] float minimumTime = 0.3f;
    [SerializeField] float timeBetweenSetGenerate = 2f;


    // Take first points for way
    public Transform GetStartElement()
    {
        return wayPrefab.GetChild(0);
    }

    // Take all points for way
    public List<Transform> GetWay()
    {
        List<Transform> wayElements = new List<Transform>();
        wayPrefab.GetComponentsInChildren<Transform>(wayElements);
        wayElements.Remove(wayPrefab.transform);
        return wayElements;
    }

    public int GetEnemiesCount()
    {
        return enemyPrefabs.Count;
    }
    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefabs[index];
    }

    public float GetSpeed()
    {
        return speed;
    }

    public float GetRandomTimeBetweenEnemy(bool isEndOfSet)
    {
        return GetRandomTimeWithVariance(
            isEndOfSet ? timeBetweenSetGenerate : timeBetweenEnemyGenerate); 
    }
    
    float GetRandomTimeWithVariance(float baseTime) 
    {
        float nextTime = Random.Range(baseTime - timeVariance,
                                  baseTime + timeVariance);
        return Mathf.Clamp(nextTime, minimumTime, float.MaxValue);

    }
}

