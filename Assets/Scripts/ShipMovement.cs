using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] float speedShip = 3f;
    Vector2 inputVector;

    [SerializeField] float deltaTopBorder;
    [SerializeField] float deltaDefaultBorder;
 
    Vector2 minShipPosition;
    Vector2 maxShipPosition;

    Firing firing;

    void Awake()
    {
        firing = GetComponent<Firing>();
    }


    // Start is called before the first frame update
    void Start()
    {
        InitMinMaxPosition();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    //Init min and max position for Player Ship
    void InitMinMaxPosition()
    {
        Camera mainCamera = Camera.main;
        Vector3 deltaMax = new Vector3(deltaDefaultBorder, deltaTopBorder, 0);
        Vector3 deltaMin = new Vector3(deltaDefaultBorder, deltaDefaultBorder, 0);
        minShipPosition = mainCamera.ViewportToWorldPoint(new Vector2(0, 0)) + deltaMin;
        maxShipPosition = mainCamera.ViewportToWorldPoint(new Vector2(1, 1)) - deltaMax;
        
    }


    void Movement()
    {
        Vector3 movePosition = inputVector * speedShip * Time.deltaTime;
        movePosition += transform.position;
        // Check position is in allowed bounds
        movePosition.x = Mathf.Clamp(movePosition.x, minShipPosition.x, maxShipPosition.x);
        movePosition.y = Mathf.Clamp(movePosition.y, minShipPosition.y, maxShipPosition.y);
       
        transform.position = movePosition;
    }

    void OnMove(InputValue value)
    {
        inputVector = value.Get<Vector2>();
    }

    void OnFire(InputValue value)
    {
        if (firing != null)
        {
            firing.SetFire(value.isPressed);
        }
    }

}
