using UnityEngine;

public class UnloadFirstPartOfMap : MonoBehaviour
{
    public MeshRenderer[] unloadMesh;
    public Collider[] unloadCollider;
    public MeshRenderer meshRenderer, meshRenderer2;
    public BoxCollider boxCollider, boxCollider2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (MeshRenderer unloadMeshRenderer in unloadMesh)
            {
                unloadMeshRenderer.enabled = false;
            }
            foreach (Collider unloadCollider in unloadCollider)
            { 
                unloadCollider.enabled = false; 
            }
            meshRenderer.enabled = false;
            meshRenderer2.enabled = true;
            boxCollider.enabled = false;
            boxCollider2.enabled = true;
        }
    }
}
