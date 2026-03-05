using UnityEngine;

public class UnloadSecondPartOfMap : MonoBehaviour
{
    public MeshRenderer[] unloadMesh;
    public Collider[] unloadCollider;
    public MeshRenderer meshRenderer, meshRenderer2;
    public BoxCollider boxCollider, boxCollider2;
    public bool unload = false;


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
        if (unload == false)
        {
            if (other.CompareTag("Player"))
            {
                foreach (MeshRenderer unloadMeshRenderer in unloadMesh)
                {
                    unloadMeshRenderer.enabled = true;
                }
                foreach (Collider unloadCollider in unloadCollider)
                {
                    unloadCollider.enabled = true;
                }
                meshRenderer.enabled = false;
                meshRenderer2.enabled = true;
                boxCollider.enabled = false;
                boxCollider2.enabled = true;
            }
        }
        else if (unload == true)
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
