using UnityEngine;

public class PlaceCylinderObject1 : Interactable
{
    public CylinderHold1 cylinderHold1;
    private MeshRenderer objectRenderer;
    private BoxCollider objectCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        objectCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        if (cylinderHold1.onHold == true)
        {
            cylinderHold1.isItemPutBack = true;
            objectRenderer.enabled = false;
            objectCollider.enabled = false;
        }
        else if (cylinderHold1.onHold == false)
        {
            Debug.Log("You need to be holding the item to place it here.");
        }
    }
}
