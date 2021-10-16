using UnityEngine;

//Controls player ship movement and screen wrapping

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    float screenWidthInWorldUnits;
    float halfPlayerWidth;
    //int pauseInt;

    public event System.Action OnPlayerDeath;
    void Start()
    {
        halfPlayerWidth = transform.localScale.x / 2f;
        screenWidthInWorldUnits = Camera.main.orthographicSize * Camera.main.aspect + halfPlayerWidth;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(input * moveSpeed * Time.deltaTime);
        if (transform.position.x < -screenWidthInWorldUnits)
        {
            transform.position = new Vector2(screenWidthInWorldUnits, transform.position.y);
        }

        if (transform.position.x > screenWidthInWorldUnits)
        {
            transform.position = new Vector2(-screenWidthInWorldUnits, transform.position.y);
        }

        if (transform.position.y < -(Camera.main.orthographicSize - transform.localScale.y/2))
        {
            transform.position = new Vector2(transform.position.x, -(Camera.main.orthographicSize - transform.localScale.y / 2));
        }
        
        if (transform.position.y > (Camera.main.orthographicSize - transform.localScale.y / 2))
        {
            transform.position = new Vector2(transform.position.x, (Camera.main.orthographicSize - transform.localScale.y / 2));
        }


        //pause system

        //pauseInt = 0;
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    Time.timeScale = 0;
        //    pauseInt = 1;
        //    Input.
        //}
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
		if (collider.CompareTag("Asteroid"))
        {
            OnPlayerDeath.Invoke();
            Destroy(gameObject);
        }
        
    }
}
