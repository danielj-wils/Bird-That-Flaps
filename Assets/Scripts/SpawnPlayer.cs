using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public static SpawnPlayer instance;

    public GameObject RedBird;
    public GameObject BlueBird;
    public GameObject PinkBird;

    private void Awake() 
    {
        // Singleton pattern - prevent multiple instances
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        CheckSpriteToSpawn();
    }

    private void CheckSpriteToSpawn()
    {
        // Validate that ScenesManager instance is not null
        if (ScenesManager.instance == null)
        {
            Debug.LogError("ScenesManager instance is null!");
            return;
        }

        // Define spawn position
        Vector3 spawnPosition = transform.position;

        // Spawn based on sprite color selection using switch for cleaner logic
        switch (ScenesManager.instance.spriteColourSelection.ToLower())
        {
            case "red":
                Instantiate(RedBird, spawnPosition, Quaternion.identity);
                break;
            case "blue":
                Instantiate(BlueBird, spawnPosition, Quaternion.identity);
                break;
            case "pink":
                Instantiate(PinkBird, spawnPosition, Quaternion.identity);
                break;
            default:
                Instantiate(RedBird, spawnPosition, Quaternion.identity);
                Debug.LogError("Default sprite color selected: " + ScenesManager.instance.spriteColourSelection);
                break;
        }
    }
}
