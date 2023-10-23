using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    float PositionY;

    public GameObject[] SpawnObject;
    
    void Start()
    {
        // Initial delay of 1 with repetition of 1
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    void Update()
    {
       
    }

    void SpawnObjects()
    {
        // Random y value is assigned to spawner.
        PositionY = Random.Range(4, -4f);

        // The spawner is jumping position.
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        // Generate random number to refer to element. (Length is from 0 to 3, so numbers generated are 0, 1, and 2?)
        int randomNum = Random.Range(0, SpawnObject.Length);
        Instantiate(SpawnObject[randomNum], transform.position, transform.rotation);
    }
}
