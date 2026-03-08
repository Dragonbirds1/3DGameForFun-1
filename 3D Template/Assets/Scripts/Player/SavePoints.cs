using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using System.Collections;
using System.Collections.Generic;
using System;

public class SavePoints : MonoBehaviour
{
    /// <summary>
    /// This script will handle the save spot in the game and make the player spawn there when dead.
    /// </summary>
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SaveManager.SaveCheckpoint(other.transform.position);
            Debug.Log("Checkpoint saved at: " + other.transform.position);
        }
    }
}
