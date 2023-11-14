using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem effect;
    [SerializeField] bool applyCameraEffect;

    AudioController audioControl;

    CameraEffect cameraEffect;
    private void Awake()
    {
        cameraEffect = Camera.main.GetComponent<CameraEffect>();
        audioControl = FindObjectOfType<AudioController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayExplosionEffect(collision);
        audioControl.PlayHitSound();
        PlayCameraEffect();
    }

    private void PlayExplosionEffect (Collider2D collision)
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
    private void PlayCameraEffect()
    {
        if (applyCameraEffect && cameraEffect != null)
        {
            cameraEffect.MakeCameraEffect();
        }
    }


}
