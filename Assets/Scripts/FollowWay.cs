using System.Collections.Generic;
using System.Collections;
using UnityEngine;

// The object follow the way from wayElements
public class  FollowWay: MonoBehaviour
{
    GenerateEnemies generator;
    EnemySetObject currentSet;
    List<Transform> wayElements;
    int elementIndex = 0;

    void Awake()
    {
        generator = GetComponentInParent<GenerateEnemies>();
     }

    void Start()
    {
        currentSet = generator.GetCurrentSet();
        wayElements = currentSet.GetWay();
        transform.position = wayElements[elementIndex].position;
    }

    void Update()
    {
        Follow();
    }

    // Enemy follow the way by elements (points)
    void Follow()
    {
        if (elementIndex < wayElements.Count)
        {
            Vector3 targetPosition = wayElements[elementIndex].position;
            float delta = currentSet.GetSpeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, delta);
            if (transform.position == targetPosition)
            {
                elementIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

