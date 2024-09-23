using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPersistence : MonoBehaviour
{
    public static AudioPersistence instance;
    
    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
