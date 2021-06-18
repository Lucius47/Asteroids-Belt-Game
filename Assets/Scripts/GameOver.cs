//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text scoreText;
    int score;
    int highScore;

    bool gameOver;
    void Start()
    {
        highScore = PlayerPrefs.GetInt("High Score");
        FindObjectOfType<PlayerController>().OnPlayerDeath += OnGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(1);
            }
        }


        //moe this to a separate script later.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void OnGameOver()
    {
        score = Mathf.RoundToInt(Time.timeSinceLevelLoad);
        
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("High Score", highScore);
            PlayerPrefs.Save();
        }
        
        gameOverUI.SetActive(true);
        scoreText.text = score.ToString();
        gameOver = true;
    }
}
