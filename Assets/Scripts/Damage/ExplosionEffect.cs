using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (effect != null)
        {
            Vector3 hitPoint = collision.ClosestPoint(transform.position);
            ParticleSystem instance = Instantiate(
                                        effect, hitPoint, Quaternion.identity);
            float lifeTime = instance.main.duration + instance.main.startLifetime.constantMax;
            Destroy(instance.gameObject, lifeTime);
        }
    }
}
