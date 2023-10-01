using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightOffset = 10;

    void Start() {
        SpawnPipe();
    }

    void Update()
    {
        if( timer > spawnRate) {
            SpawnPipe();
            timer = 0;
        } else {
            timer += Time.deltaTime;
        }        
    }
    void SpawnPipe() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
