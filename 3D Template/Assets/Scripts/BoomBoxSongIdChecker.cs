using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using System;

public class BoomBoxSongIdChecker : MonoBehaviour
{
    /// <summary>
    /// This script is intended to check a song ID that the player inputs into the BoomBox.
    /// What will happen is that the script will look for the song ID online to see if there is a match.
    /// How this will be done is that the script will send a web request to a server that has a database of song IDs.
    /// More functionality will be added in the future.
    /// </summary>
    
    // CheckSongIdCoroutine


    [SerializeField]
    public string songIdToCheck;
    [SerializeField]
    private string serverUrl = "https://example.com/checkSongId"; // Placeholder URL
    [SerializeField]
    private string result;
    [SerializeField]
    private bool isChecking;
    [SerializeField]
    private bool isValidSongId;
    [SerializeField]
    public float checkInterval = 5.0f; // Time in seconds between checks
    public float checkTimer;
    [SerializeField]
    public TMP_Text textMeshPro;
    // AudioSource will be used to play the song if the ID is valid
    public AudioSource audioSource;
    // Keycode to trigger the check
    public KeyCode checkKey;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        songIdToCheck = textMeshPro.text;
        if (isChecking)
        {
            checkTimer += Time.deltaTime;
            if (checkTimer >= checkInterval)
            {
                checkTimer = 0f;
                StartCoroutine(CheckCoroutine());
            }
        }
        if (isValidSongId)
        {
            // Play the song using the AudioSource
            if (!audioSource.isPlaying)
            {
                // Placeholder logic to load and play the song
                // In a real implementation, you would load the audio clip based on the song ID
                Debug.Log("Playing song with ID: " + songIdToCheck);
                // AudioClip is based on songIdToCheck
                AudioClip clip = Resources.Load<AudioClip>("Songs/" + songIdToCheck); // Example path
                // load clip and play
                audioSource.PlayOneShot(clip, 1);
                // audioSource.clip = ... load clip based on songIdToCheck ...
                // audioSource.Play();
            }
        }
        if (Input.GetKeyDown(checkKey))
        {
            // Check the song ID when the key is pressed
            CheckSongId(songIdToCheck);
        }
    }

    // Coroutine to check the song ID

    IEnumerator CheckCoroutine()
    {
        // Search for the song ID on the server
        isChecking = true;
        // Handle the web request and response
        HandleServerResponse("valid"); // Placeholder response
        UnityWebRequest www = UnityWebRequest.Get(serverUrl + "?songId=" + songIdToCheck);


        yield return new WaitForSeconds(checkInterval);

        // Debug log to indicate if the request was sent
        Debug.Log("Sending request to check song ID: " + songIdToCheck);
    }


    // Method to initiate the song ID check
    public void CheckSongId(string songId)
    {
        if (!isChecking)
        {
            songIdToCheck = songId;
            StartCoroutine(CheckCoroutine());
        }
    }

    // Method to handle the server response
    private void HandleServerResponse(string response)
    {
        // Placeholder logic for handling server response
        if (response.Contains("valid"))
        {
            isValidSongId = true;
            result = "Valid Song ID";
        }
        else
        {
            isValidSongId = false;
            result = "Invalid Song ID";
        }
        // Update the TextMeshPro component with the result
        if (textMeshPro != null)
        {
            textMeshPro.text = result;
        }
    }

    // G

    // Method to get the result of the song ID check
    public string GetResult()
    {
        return result;
    }

    // Method to check if the song ID is valid
    public bool IsValidSongId()
    {
        return isValidSongId;
    }

    // Method to check if a check is in progress
    public bool IsChecking()
    {
        return isChecking;
    }

    // Method to set the server URL
    public void SetServerUrl(string url)
    {
        serverUrl = url;
    }

}
