using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**************************************************
 * compentent of spawn manager, spawn animals 
 * into the scene but out of view.
 * 
 * Bryce Haddock
 * October 13, 2023 version 1.0
 * ***********************************************/

public class SpawnManager : MonoBehaviour
{
    private float spawnRange = 24.0f;           //distance to edge from center of field
    private float startDelay = 1.5f;            //time before first spawn
    private float spawnInterval = 1.5f          //interval between spawns
    [SerializeField] gameObject[] animals;      //list of animals to spawn

    // calls the SpawnRandomAnimal method after a certain delay, then every interval
    private void Start()
    {
        
    }

    // adds a random animal at a random point between the spawn ranges
    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosition
    }
}
