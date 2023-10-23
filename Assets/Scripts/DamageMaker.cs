using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker : MonoBehaviour
{
    [SerializeField] int damage = 10;

    public int MakedDamage()
    {
        return damage;
    }

 }
