using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawn : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnPipe();
            timer = 0;
        }
        
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); 
    }
}

