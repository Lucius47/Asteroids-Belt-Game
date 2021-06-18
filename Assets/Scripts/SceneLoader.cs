//using System;
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    GameOver gameOver;
    public Text highScore;

    private void Start()
    {
        
        highScore.text = PlayerPrefs.GetInt("High Score").ToString();
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
}
