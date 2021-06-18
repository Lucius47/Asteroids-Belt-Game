//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Vector2 minMaxSpeed;
    float speed;
    float visibleScreen;
    void Start()
    {
		speed = Mathf.Lerp(minMaxSpeed.x, minMaxSpeed.y, Difficulty.GetDifficulty());
        visibleScreen = -Camera.main.orthographicSize - transform.localScale.y;
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y < visibleScreen)
        {
            Destroy(gameObject);
        }
    }
}
