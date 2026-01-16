using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class BoomBoxSongIdChecker : MonoBehaviour
{
    /// <summary>
    /// This script is intended to check a song ID that the player inputs into the BoomBox.
    /// What will happen is that the script will look for the song ID online to see if there is a match.
    /// How this will be done is that the script will send a web request to a server that has a database of song IDs.
    /// More functionality will be added in the future.
    /// </summary>
    
    // CheckSongIdCoroutine

    // AudioSource will be used to play the song if the ID is valid
    public AudioSource audioSource;
    // Keycode to trigger the check
    public KeyCode checkKey;
    // Button to trigger the check
    public Button playButton;
    public InputField songIdInputField;




    void Start()
    {
        playButton.onClick.AddListener(OnPlayButtonClick);
    }

    void OnPlayButtonClick()
    {
        string songId = songIdInputField.text;
        // In a real application, you would use the ID to query a web API for the actual audio URL.
        // This example uses a placeholder URL as a demonstration.
        string audioUrl = "YOUR_AUDIO_URL_HERE" + songId + ".mp3"; // Example structure
        StartCoroutine(DownloadAndPlayAudio(audioUrl));
    }

    IEnumerator DownloadAndPlayAudio(string url)
    {
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG)) // Use appropriate AudioType
        {
            yield return www.SendWebRequest();

            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError(www.error);
            }
            else
            {
                AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
                audioSource.clip = clip;
                audioSource.Play();
                Debug.Log("Playing: " + url);
            }
        }
    }
}
