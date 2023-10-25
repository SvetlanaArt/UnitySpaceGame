using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    [SerializeField] int life = 100;

    public int Life {  
        get 
        {             
            return life; 
        } 
        set {  
            life = value; 
        } 
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
        life -= damage;
    }

    private void Update()
    {
        CheckLife();
    }

    void CheckLife()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

}
