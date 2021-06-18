//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class AudioPlayerManager : MonoBehaviour
{
    private static AudioPlayerManager instance = null;
    private new AudioSource audio;
    private static VideoPlayer VideoPlayer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        if (instance == this) return;
        Destroy(gameObject);
    }

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
