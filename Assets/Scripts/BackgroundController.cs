using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    
    [SerializeField]
    float speed = 0.2f;
    
    private Vector2 delta;
    Material matBack;


    void Awake()
    {
        delta = new Vector2(0f, 0f);
        matBack = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //move background
        delta.y = speed * Time.deltaTime;
        matBack.mainTextureOffset += delta;
    }
}
