using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    [SerializeField] GameObject lizerPrefab;
    [SerializeField] float lizerSpeed = 12f;
    [SerializeField] float lazerPeriod = 0.3f;
    [SerializeField] float lazerTimeVariance = 0.1f;
    [SerializeField] float minimumTime = 0.1f;

    bool isFire;
    RandomGenerator randomTime;
    float nextTime;

    Coroutine fireCoroutine;

    AudioController audioControl;

    private void Awake()
    { 
        isFire = false;
        randomTime = FindObjectOfType<RandomGenerator>();
        fireCoroutine = null;
        audioControl = FindObjectOfType<AudioController>();
    }
 
    public void SetFire(bool enable)
    {
        isFire = enable;
    }

    void Update()
    {
        CheckFiring();
    }

     void CheckFiring()
    {
        bool isFiringNow = (fireCoroutine != null);
        if (isFire && !isFiringNow)
        {
            fireCoroutine = StartCoroutine(Fire());
        }
        else if(!isFire && isFiringNow)
        {
            StopCoroutine(fireCoroutine);
            fireCoroutine = null;
        }
    }

    IEnumerator Fire()
    {
        nextTime = lazerPeriod;
        while (true)
        {
            GameObject laserBullet = Instantiate( lizerPrefab, 
                                                  transform.position, 
                                                  Quaternion.identity);
            Rigidbody2D rbody = laserBullet.GetComponent<Rigidbody2D>();
            if(rbody != null)
            {
                rbody.velocity = transform.up * lizerSpeed;
            }
            if (audioControl != null)
            {
                audioControl.PlayLaserSound();
            }
            if (randomTime != null)
            {
                nextTime = randomTime.GetRandomTimeWithVariance(lazerPeriod,
                                                            lazerTimeVariance,
                                                            minimumTime);
            }
            yield return new WaitForSeconds(nextTime);
        }
    }

}
