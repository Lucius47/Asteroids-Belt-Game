using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundVideo : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }


}

