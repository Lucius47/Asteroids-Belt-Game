using UnityEngine;

//Attached with each asteroid object
//Gives downwards movement and random rotation.

public class Asteroid : MonoBehaviour
{
    public Vector2 minMaxSpeed;
    float speed;
    float visibleScreen;
    float rotation = 0;

    [SerializeField] Transform sprite = null;

    void Start()
    {
		speed = Mathf.Lerp(minMaxSpeed.x, minMaxSpeed.y, Difficulty.GetDifficulty());
        rotation = Random.Range(-1f, 1f);
        visibleScreen = -Camera.main.orthographicSize - transform.localScale.y;
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
        sprite.transform.Rotate(0, 0, rotation);
        if (transform.position.y < visibleScreen)
        {
            Destroy(gameObject);
            Destroy(sprite);
        }

        
    }
}
