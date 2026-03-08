using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerRespawn : MonoBehaviour
{
    public List<GameObject> deathPopup;

    public void RespawnAtCheckpoint()
    {
        if (SaveManager.HasCheckpoint())
        {
            Vector3 checkpoint = SaveManager.LoadCheckpoint();

            foreach (GameObject gameObject in deathPopup)
            {
                gameObject.SetActive(false);
            }

            // Disable CharacterController temporarily
            CharacterController cc = GetComponent<CharacterController>();
            if (cc != null) cc.enabled = false;

            transform.position = checkpoint;

            if (cc != null) cc.enabled = true;

            // Reset Rigidbody velocity if you have one
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            Debug.Log("Player respawned at checkpoint: " + checkpoint);
        }
        else
        {
            Debug.Log("No checkpoint saved, staying at original position.");
        }

        // Here you can also reset player health, status, etc.
    }
}