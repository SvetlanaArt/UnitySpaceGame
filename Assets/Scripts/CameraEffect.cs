using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffect : MonoBehaviour
{
    [SerializeField] float effectTime = 0.5f;
    [SerializeField] float effectAmplitude = 0.25f;

    Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = transform.position;
    }
    public void MakeCameraEffect()
    {
        StartCoroutine(Effect());
    }

    IEnumerator Effect()
    {
        float duration = 0;
        while (duration < effectTime)
        {
            transform.position = cameraPosition + 
                                Random.insideUnitSphere * effectAmplitude;
            duration += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = cameraPosition;
    }

}
