using UnityEngine;

public class StartWeeping : MonoBehaviour
{
    /// <summary>
    /// This script will be for starting the weeping bean event.
    /// </summary>
    
    public WeepingBean weeping;
    private MeshRenderer meshRenderer;
    private BoxCollider boxCollider;
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
            meshRenderer.enabled = false;
            boxCollider.enabled = false;
            weeping.enabled = true;
            weeping.canMove = true;
        }
    }
}
