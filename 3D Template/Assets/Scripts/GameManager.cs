using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab; // Assign your player prefab here
    private static Vector3 lastCheckpoint = Vector3.zero; // Last saved checkpoint
    private static bool hasCheckpoint = false;           // Whether a checkpoint exists

    void Awake()
    {
        // Spawn player at last checkpoint if available
        Vector3 spawnPos = hasCheckpoint ? lastCheckpoint : Vector3.zero;
        GameObject player = Instantiate(playerPrefab, spawnPos, Quaternion.identity);
        player.name = "Player"; // Optional: give it a consistent name
    }

    // Call this from your checkpoint trigger
    public static void SaveCheckpoint(Vector3 pos)
    {
        lastCheckpoint = pos;
        hasCheckpoint = true;
        Debug.Log("Checkpoint saved at: " + pos);
    }

    // Call this when the player dies
    public static void Respawn()
    {
        // Reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}