using Unity.VisualScripting;
using UnityEngine;

public class WinRedLight : MonoBehaviour
{
    /// <summary>
    /// This script will tell the red light green light script that the player has won the game, so it can stop switching between red and green light and stop checking for player movement when it's red light.
    /// </summary>

    private MeshRenderer meshRenderer;
    private BoxCollider boxCollider;

    public RedLightGreenLight redLightGreenLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            redLightGreenLight.winGame = true; // Set the winGame variable in the RedLightGreenLight script to true when the player enters the trigger
            meshRenderer.enabled = false; // Disable the mesh renderer to make the object invisible
            boxCollider.enabled = false; // Disable the box collider to prevent further collisions
        }
    }
}
