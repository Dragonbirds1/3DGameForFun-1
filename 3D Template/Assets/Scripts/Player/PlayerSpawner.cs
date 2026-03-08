using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;

    private void Awake()
    {
        Vector3 spawnPosition = Vector3.zero;

        // Check if there is a saved checkpoint
        if (SaveManager.HasCheckpoint())
        {
            spawnPosition = SaveManager.LoadCheckpoint();
            Debug.Log("Spawning player at checkpoint: " + spawnPosition);
        }
        else
        {
            Debug.Log("Spawning player at default spawn");
        }

        // Instantiate the player at the chosen position
        Instantiate(playerPrefab, spawnPosition, Quaternion.identity);
    }
}