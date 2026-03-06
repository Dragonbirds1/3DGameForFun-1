using UnityEngine;

public class SaveManager : MonoBehaviour
{
    // Key for the saved position X, Y, and Z
    private const string SavePointXKey = "SavePointX";
    private const string SavePointYKey = "SavePointY";
    private const string SavePointZKey = "SavePointZ";

    // Function called by the SavePointTrigger
    public static void SaveGameData(Vector3 playerPosition)
    {
        PlayerPrefs.SetFloat(SavePointXKey, playerPosition.x);
        PlayerPrefs.SetFloat(SavePointYKey, playerPosition.y);
        PlayerPrefs.SetFloat(SavePointZKey, playerPosition.z);
        PlayerPrefs.Save(); // Commit the changes to disk
        Debug.Log("Game Saved!");
    }

    // Function to load the saved position (e.g., when the player dies or loads the game)
    public static Vector3 LoadGameData()
    {
        if (PlayerPrefs.HasKey(SavePointXKey))
        {
            float x = PlayerPrefs.GetFloat(SavePointXKey);
            float y = PlayerPrefs.GetFloat(SavePointYKey);
            float z = PlayerPrefs.GetFloat(SavePointZKey);
            return new Vector3(x, y, z);
        }
        else
        {
            // Return a default start position if no save data is found
            return Vector3.zero;
        }
    }
}
