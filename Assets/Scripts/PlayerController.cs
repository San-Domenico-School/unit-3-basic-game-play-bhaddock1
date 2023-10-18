using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/******************************************
 * component of player, player controller
 * moves player on input and prevents player from travelling out of bounds
 * 
 * Bryce Haddock
 * October 13, 2023 version 1.0
 * **************************************/

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;      //initializes projectile

    private float speed;                //initializes speed
    private float CenterToEdge;         //initializes centertoedge
    private float move;                 //initializes move

    //initializes speed and center to edge on start
    private void Start()
    {
        speed = 3.0f;
        CenterToEdge = 24f;
    }

    // Call on player movement each frame
    private void Update()
    {
  
        PlayerMovement();
    }
    //keeps player in bounds of scene and allows player to move left and right
    private void PlayerMovement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed * move);
        if(Mathf.Abs(transform.position.x) > CenterToEdge)
        {
            float edge = CenterToEdge;
            if(transform.position.x < 0)
            {
                edge = -CenterToEdge;
            }
            transform.position = new Vector3(CenterToEdge, transform.position.y, transform.position.z);
        }
    }

    // called when move action of playerInputAction is detected. sets the move field to either 1 or -1 based on x value of inputs vector2.
    private void OnMove(InputValue input)
    {
        Vector2 moveDirection = input.Get<Vector2>();
        move = moveDirection.x;
        Debug.Log(move);
    }
    //fires projectile on fire action
    private void OnFire()
    {
        Instantiate(projectile, transform.position + Vector3.up, projectile.transform.rotation);
    }
}
