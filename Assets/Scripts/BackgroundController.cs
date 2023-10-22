using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float speed = 0.5f;
    [SerializeField]
    private SpriteRenderer spriteBack1; //the upper sprite for background

    private Vector2 startPosition;
    private float maxPosition;
    
    
    void Awake()
    {
        startPosition = transform.position;
        maxPosition = spriteBack1.transform.position.y - startPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        //move background
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        //check position to emulate endless background 
        if(transform.position.y <= -maxPosition)
        {
            transform.position = startPosition;
        }
    }
}
