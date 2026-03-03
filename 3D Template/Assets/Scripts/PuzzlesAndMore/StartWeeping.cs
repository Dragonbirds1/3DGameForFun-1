using UnityEngine;

public class StartWeeping : MonoBehaviour
{
    /// <summary>
    /// This script will be for starting the weeping bean event.
    /// </summary>
    
    public WeepingBean weeping;
    public GeneratorHealth generatorHealth;
    public Rigidbody rb;
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
            rb.useGravity = true;
            generatorHealth.health = 0;
            meshRenderer.enabled = false;
            boxCollider.enabled = false;
            if (weeping != null)
            {
                weeping.enabled = true;
                weeping.canMove = true;
            }
            else if (weeping == null)
            {
                Debug.Log("No Weeping Bean To Start!");
            }
        }
    }
}
