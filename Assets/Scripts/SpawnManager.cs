using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    public Vector3 spawnPosition;
    private float randomX;
    private float randomY;
    private float randomZ;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 RandomSpawnPosition()
    {
        return new Vector3(randomX, randomY, randomZ);
    }
    public void SpawnObstacle()
    {
        int randomX = Random.Range(-200, 200);
        int randomY = Random.Range(-30, 100);
        int randomZ = Random.Range(-100, 200);
        spawnPosition = RandomSpawnPosition();
        Instantiate(obstacle, spawnPosition,
        obstacle.transform.rotation);
    }
}
