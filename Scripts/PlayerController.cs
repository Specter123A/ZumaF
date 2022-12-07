using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //initial variables 
    private Camera cam;
    private Rigidbody2D rb;
    private Vector2 movement;

    //To be able to set movement speed 
    [SerializeField]
    private float speed = 2f;


// Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        //rb = GetComponent<Rigidbody2D>();  //using physics based engine, so get Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();  //update is called every frame, we need to see if any input is provided. 
        MouseDirection();
    }

    private void FixedUpdate()
    {
        // rb.velocity = movement * speed;  //physics based movement. 
    }

    private void GetInput()  //GetAxis for the inputs
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    private void MouseDirection()
    {
        if(cam is null) return; //if there is no camera it wont move or do anything

        // if the camera is active, the player will look in the direction of the MouseDirection
        // Movement will be through the Horizontal and Vertical axis as defined in GetInput()

        var dir = Input.mousePosition - cam.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg -90f;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}