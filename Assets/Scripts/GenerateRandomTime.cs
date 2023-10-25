using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomTime : MonoBehaviour
{
 
    /// <summary>
    /// 
    /// </summary>
    /// <param name="baseTime"></param> base time for random value
    /// <param name="variance"></param> delta for random value
    /// <param name="min"></param> minimum availible value
    /// <returns></returns>
    public float GetRandomTimeWithVariance(float baseTime, float variance, float min)
    {
        float nextTime = Random.Range(baseTime - variance,
                                  baseTime + variance);
        return Mathf.Clamp(nextTime, min, float.MaxValue);

    }
}
