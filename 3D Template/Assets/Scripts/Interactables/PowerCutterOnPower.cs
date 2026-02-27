using UnityEngine;

public class PowerCutterOnPower : Interactable
{
    public PickUpPowerCutter pickUpPowerCutter;
    private MeshRenderer objectRenderer;
    private BoxCollider objectCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        if (pickUpPowerCutter.onHold == true)
        {
            pickUpPowerCutter.isItemPutBack = true;
            objectRenderer.enabled = false;
            objectCollider.enabled = false;
        }
        else if (pickUpPowerCutter.onHold == false)
        {
            Debug.Log("You need to be holding the item to place it here.");
        }
    }
}
