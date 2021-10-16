using UnityEngine;

//Spawns asteroids

public class Spawner : MonoBehaviour
{
    public GameObject asteroid;
    
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
            float asteroidSize = Random.Range(minMaxSize.x, minMaxSize.y);
            spawnPosition = new Vector2(Random.Range(-screenWidth.x, screenWidth.x), screenWidth.y + asteroidSize/2f);
            float spawnAngle = Random.Range(-maxSpawnAngle, maxSpawnAngle);

            

            //Create a new GameObject below if there's some problem.
            asteroid = (GameObject)Instantiate(asteroid, spawnPosition, Quaternion.Euler(Vector3.forward * spawnAngle));
            asteroid.transform.localScale = Vector3.one * asteroidSize;

            //For background

            //backgroundFB = (GameObject)Instantiate(backgroundFB, spawnPosition, Quaternion.Euler(Vector3.forward * Random.Range(-maxSpawnAngle, maxSpawnAngle)));
        }
        
    }
}
