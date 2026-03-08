using UnityEngine;

public static class SaveManager
{
    private const string SaveX = "SavePointX";
    private const string SaveY = "SavePointY";
    private const string SaveZ = "SavePointZ";

    public static void SaveCheckpoint(Vector3 pos)
    {
        PlayerPrefs.SetFloat(SaveX, pos.x);
        PlayerPrefs.SetFloat(SaveY, pos.y);
        PlayerPrefs.SetFloat(SaveZ, pos.z);
        PlayerPrefs.Save();
        Debug.Log("Checkpoint saved at: " + pos);
    }

    public static Vector3 LoadCheckpoint()
    {
        if (PlayerPrefs.HasKey(SaveX))
        {
            float x = PlayerPrefs.GetFloat(SaveX);
            float y = PlayerPrefs.GetFloat(SaveY);
            float z = PlayerPrefs.GetFloat(SaveZ);
            return new Vector3(x, y, z);
        }
        return Vector3.zero; // Default spawn if no checkpoint
    }

    public static bool HasCheckpoint()
    {
        return PlayerPrefs.HasKey(SaveX);
    }
}