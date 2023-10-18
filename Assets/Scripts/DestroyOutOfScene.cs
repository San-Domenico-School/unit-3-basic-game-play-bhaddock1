using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfScene : MonoBehaviour
{
    private float upperBound;
    private float lowerBound;

    // Start is called before the first frame update
    private void Start()
    {
        upperBound = 30.0f;
        lowerBound = -7.0f;
    }

    // Update is called once per frame
    private void Update()
    {
        DestroyOutOfBounds();
    }
    private void DestroyOutOfBounds()
    {
        if (gameObject.transform.position.z > upperBound || gameObject.transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
