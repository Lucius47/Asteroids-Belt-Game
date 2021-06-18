using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fallingBlock;
    
    Vector2 screenWidth;
    Vector2 spawnPosition;

    public Vector2 minMaxTimeBetweenSpawns;
    float nextSpawnTime;
    public float maxSpawnAngle;
    public Vector2 minMaxSize;

    //For background

    //public GameObject backgroundFB;

    void Start()
    {
        screenWidth = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float timeBetweenSpawns = Mathf.Lerp(minMaxTimeBetweenSpawns.y, minMaxTimeBetweenSpawns.x, Difficulty.GetDifficulty());
            
            nextSpawnTime = Time.time + timeBetweenSpawns;
            float blockSize = Random.Range(minMaxSize.x, minMaxSize.y);
            spawnPosition = new Vector2(Random.Range(-screenWidth.x, screenWidth.x), screenWidth.y + blockSize/2f);
            float spawnAngle = Random.Range(-maxSpawnAngle, maxSpawnAngle);

            

            //Create a new GameObject below if there's some problem.
            fallingBlock = (GameObject)Instantiate(fallingBlock, spawnPosition, Quaternion.Euler(Vector3.forward * spawnAngle));
            fallingBlock.transform.localScale = Vector3.one * blockSize;

            //For background

            //backgroundFB = (GameObject)Instantiate(backgroundFB, spawnPosition, Quaternion.Euler(Vector3.forward * Random.Range(-maxSpawnAngle, maxSpawnAngle)));
        }
        
    }
}
