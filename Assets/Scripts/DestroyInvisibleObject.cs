using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyInvisibleObject : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Camera mainCamera = Camera.main;
        if (mainCamera != null )
        {
            Vector3 checkedPos = mainCamera.WorldToViewportPoint(transform.position);
            if (checkedPos.x > 1 || checkedPos.x < 0 || checkedPos.y > 1 || checkedPos.y < 0)
            {
                if (transform.parent != null)
                {
                    Destroy(transform.parent.gameObject);
                }
                else
                {
                    Destroy(gameObject);
                }

            }
        }
     }
}
