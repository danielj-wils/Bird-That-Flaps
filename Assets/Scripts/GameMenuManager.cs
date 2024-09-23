using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuManager : MonoBehaviour
{
    public GameObject gameMenuUI;
    public GameObject pauseMenuUI;

    public Button playAgainButton;
    public Button menuButton1;
    public Button restartButton;
    public Button menuButton2;

    private void Start()
    {
        if (ScenesManager.instance != null)
        {
            // Ensure buttons call the correct methods from ScenesManager
            menuButton1.onClick.AddListener(ScenesManager.instance.LoadMenu);
            playAgainButton.onClick.AddListener(ScenesManager.instance.LoadGame);
            restartButton.onClick.AddListener(ScenesManager.instance.LoadGame);
            menuButton2.onClick.AddListener(ScenesManager.instance.LoadMenu);
        }
        else
        {
            Debug.LogError("ScenesManager instance is null!");
        }
    }

    private void Update()
    {
        if (gameMenuUI.activeSelf == true)
        {
            // Key press management for the same actions as button clicks
            if (Input.GetKeyDown(KeyCode.Space)) // space key for Play Again
            {
                ScenesManager.instance.LoadGame();
            }

            if (Input.GetKeyDown(KeyCode.M)) // M key for Menu
            {
                ScenesManager.instance.LoadMenu();
            }
        }
        if (pauseMenuUI.activeSelf ==true)
        {
            if (Input.GetKeyDown(KeyCode.R)) // R key for Restart
            {
                ScenesManager.instance.LoadGame();
            }

            if (Input.GetKeyDown(KeyCode.M)) // Escape key for Menu
            {
                ScenesManager.instance.LoadMenu();
            }
        }
    }
}
