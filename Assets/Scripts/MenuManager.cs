using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button redBirdButton;
    public Button blueBirdButton;
    public Button pinkBirdButton;
    public Button playButton;
    public Button quitButton;

    private void Start()
    {
        if (ScenesManager.instance != null)
        {
            redBirdButton.onClick.AddListener(ScenesManager.instance.AssignRedBird);
            blueBirdButton.onClick.AddListener(ScenesManager.instance.AssignBlueBird);
            pinkBirdButton.onClick.AddListener(ScenesManager.instance.AssignPinkBird);
            playButton.onClick.AddListener(ScenesManager.instance.LoadGame);
            quitButton.onClick.AddListener(Quit);
        }
        else
        {
            Debug.LogError("ScenesManager instance is null!");
        }
    }

    private void Quit()
    {
        Application.Quit();
        Debug.Log("Application quitted.");
    }
}
