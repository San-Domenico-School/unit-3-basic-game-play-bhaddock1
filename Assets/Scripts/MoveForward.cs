using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*********************************************
 * component of animals, move forward
 * moves animals forward
 * 
 * Bryce Haddock
 * October 13, 2023 version 1.0
 * ******************************************/

public class MoveForward : MonoBehaviour
{
    [Range(5, 30)]          //range of motion
    [SerializeField] 
    private float speed;    //initializes speed

    // updates animals position every frame update 
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  //move animals forward at speed variable 
    }
}
