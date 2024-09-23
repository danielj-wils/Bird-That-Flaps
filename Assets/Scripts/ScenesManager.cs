using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager instance;
    public string spriteColourSelection;

    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Persist this object across scenes
        }
        else
        {
            Destroy(gameObject);  // Avoid duplicate instances
            return;
        }
    }

    public enum Scene
    {
        Menu,
        Pipeline
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;  
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Debug.Log("Time scale set to 1 and loading menu.");
    }

    public void LoadGame()
    {
        Time.timeScale = 1.0f;  
        SceneManager.LoadScene("Pipeline", LoadSceneMode.Single);
        Debug.Log("Time scale set to 1 and loading game.");
    }

    public void AssignRedBird()
    {
        spriteColourSelection = "red";
    }

    public void AssignBlueBird()
    {
        spriteColourSelection = "blue";
    }

    public void AssignPinkBird()
    {
        spriteColourSelection = "pink";
    }
}
