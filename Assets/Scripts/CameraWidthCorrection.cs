using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraWidthCorrection: MonoBehaviour

{
    public float screenWidth = 1080f;
    private const float halfSizeInPix = 200f;

    private void Awake()
    {
        float ratioWidth = screenWidth / (float)Screen.width;
        GetComponent<Camera>().orthographicSize = ratioWidth*Screen.height/halfSizeInPix; 
    }
    

    
}
