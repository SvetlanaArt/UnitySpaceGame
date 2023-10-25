using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFiring : MonoBehaviour
{
    private Firing firing;
    
    void Awake()
    {
        firing = GetComponentInParent<Firing>();
    }

    private void OnBecameVisible()
    {
        if (firing != null)
        {
            firing.SetFire(true);
        }

    }

    private void OnBecameInvisible()
    {
        if (firing != null)
        {
            firing.SetFire(false);
         }
    }

}
