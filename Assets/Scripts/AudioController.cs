using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [Header("Laser")]
    [SerializeField] AudioClip laserSound;
    [SerializeField][Range(0f, 1f)] float laserVolume = 1f;

    [Header("Hit")]
    [SerializeField] AudioClip hitSound;
    [SerializeField][Range(0f, 1f)] float hitVolume = 1f;


    public void PlayLaserSound()
    {
        PlaySound(laserSound, laserVolume);
    }

    public void PlayHitSound()
    {
        PlaySound(hitSound, hitVolume);
    }

    void PlaySound(AudioClip sound, float volume)
    {
        if (sound != null)
        {
            AudioSource.PlayClipAtPoint(sound, 
                                        Camera.main.transform.position, 
                                        volume);
        }
    }

}
