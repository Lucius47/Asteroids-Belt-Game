using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Main Menu

public class SceneLoader : MonoBehaviour
{
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
